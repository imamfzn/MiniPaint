using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPaint.Shape;
using MiniPaint.Canvas;
using MiniPaint.LineCreator;


namespace MiniPaint
{
    public struct TransformOption
    {
        public int dx, dy;
        public Double k, alpha, m, c;

        public TransformOption(int dx, int dy, Double k, Double alpha, Double m, Double c)
        {
            this.dx = dx;
            this.dy = dy;
            this.k = k;
            this.alpha = alpha;
            this.m = m;
            this.c = c;
        }
    }

    public partial class Form1 : Form
    {
        private bool dragging;
        private Point start;
        private Bitmap drawingArea, lastDrawing, gridArea;
        private Grid grid;
        private int gridSize;
        private IDraw objectDraw;
        private TransformMatrices tm;
        public TransformOption opt { get; set; }
        public string opts {get;set;}

        public Form1()
        {
            InitializeComponent();
            dragging = false;
            start = new Point(0, 0);
            drawingArea = new Bitmap(pnlDrawingArea.Width,pnlDrawingArea.Height);
            gridArea = new Bitmap(pnlDrawingArea.Width, pnlDrawingArea.Height);
            gridSize = 50;
            grid = new Grid(gridSize, pnlDrawingArea.Width,pnlDrawingArea.Height);
            tm = new TransformMatrices(grid.GetOrigin);

            //default transformation option
            opt = new TransformOption(200, 0, 2, -Math.PI / 4, 0, 3);
        }

        private void pnlDrawingArea_Paint(object sender, PaintEventArgs e)
        {  
            e.Graphics.DrawImage(drawingArea, 0, 0);
        }

        private void pnlDrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            start = e.Location;
            lastDrawing = (Bitmap) drawingArea.Clone(); //save last object on drawing area
        }

        private void pnlDrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                objectDraw = GetDrawObject(start, e.Location);
                drawingArea.Dispose();

                if (ckTransform.Checked)
                {
                    drawingArea = (Bitmap) gridArea.Clone();
                    using (Graphics g = Graphics.FromImage(drawingArea))
                    {
                        grid.Draw(g);
                    }
                }

                else
                {
                    drawingArea = (Bitmap)lastDrawing.Clone();
                }
               
                using (Graphics g = Graphics.FromImage(drawingArea))
                {
                    objectDraw.Draw(g);
                }
                
                pnlDrawingArea.Invalidate(); //re draw
            }
        }

        private void pnlDrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
                lastDrawing.Dispose();
            }
        }

        private IDraw GetDrawObject(Point start, Point end)
        {
            if (rbLine.Checked)
            {
                if (rbLineNaive.Checked)
                {
                    return new Naive(new Line(start,end));
                } 
                else if (rbLineDDA.Checked)
                {
                    return new DDA(new Line(start, end));
                }
                else if (rbLineBresenham.Checked)
                {
                    return new Bresenham(new Line(start, end));
                }
            }

            else if (rbCircle.Checked)
            {
                int r = GetDistance(start, end);
                return new Circle(start, r);
            }

            else if (rbElips.Checked)
            {
                Point center = GetCenter(start, end);
                return new Elips(center, (int)Math.Abs(center.X - end.X), (int)Math.Abs(center.Y - end.Y));
            } 

            else if (rbPolygon.Checked)
            {
                int n = Convert.ToInt16(numericGon.Value);
                int r = GetDistance(start, end);
                double deg = Math.Atan((double)(end.Y - start.Y) / (end.X - start.X));
                return new Polygon(start, n, r, deg);
            }

            else if (rbStar.Checked)
            {
                int n = Convert.ToInt16(numericGon.Value);
                int r = GetDistance(start, end);
                double deg = Math.Atan((double)(end.Y - start.Y) / (end.X - start.X));
                return new Star(start, n, r, deg);
            }

            return null;
        }

        private int GetDistance(Point A, Point B)
        {
            return (int)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        private void btnClearArea_Click(object sender, EventArgs e)
        {
            drawingArea.Dispose();
            drawingArea = new Bitmap(pnlDrawingArea.Width, pnlDrawingArea.Height);
            pnlDrawingArea.Invalidate();
        }

        private void pnlDrawingArea_Resize(object sender, EventArgs e)
        {
            Control panel = (Control)sender;
            Bitmap resizeArea = new Bitmap(panel.Width, panel.Height);

            //..change grid size
            grid.SetGrid(gridSize, panel.Width, panel.Height);
            gridArea.Dispose();
            gridArea = new Bitmap(panel.Width, panel.Height);
            
            //change origin transformation
            tm.center = grid.GetOrigin;

            //draw grid
            using (Graphics g = Graphics.FromImage(gridArea))
            {
                grid.Draw(g);
            }

            if (drawingArea!= null)
            {
                using (Graphics g = Graphics.FromImage(resizeArea))
                {
                    g.DrawImage(drawingArea, 0, 0);
                }
                drawingArea.Dispose();
            }
            drawingArea = resizeArea;
            pnlDrawingArea.Invalidate();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if (ckTransform.Checked && objectDraw != null)
            {
                IDraw transform = objectDraw;
                if (rbTranslation.Checked)
                {
                    transform = ((ITransformation)objectDraw).Transform(tm.GetTranslation(opt.dx,opt.dy));
                }
                else if (rbRotation.Checked)
                {
                    transform = ((ITransformation)objectDraw).Transform(tm.GetRotation(opt.alpha));
                }
                else if (rbReflection.Checked)
                {
                    transform = ((ITransformation)objectDraw).Transform(tm.GetReflection(opt.m,opt.c));
                }
                else if (rbDilatation.Checked)
                {
                    transform = ((ITransformation)objectDraw).Transform(tm.GetDilatation(opt.k));
                }

                using (Graphics g = Graphics.FromImage(drawingArea))
                {
                    transform.Draw(g);
                }

                pnlDrawingArea.Invalidate();

            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            using (frmTransformationSetting OptForm = new frmTransformationSetting())
            {
                OptForm.ShowDialog();
                opt = OptForm.opt;
            }
        }

        private void cekTransform_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTransform.Checked)
            {
                using (Graphics g = Graphics.FromImage(gridArea))
                {
                    grid.Draw(g);
                }
            }
        }

        private Point GetCenter(Point A, Point B)
        {
            return new Point((int)(A.X + B.X) / 2, (int)(A.Y + B.Y) / 2);
        }
    }
}
