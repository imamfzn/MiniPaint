﻿using System;
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
    public partial class Form1 : Form
    {
        private bool dragging;
        private Point start;
        private Bitmap drawingArea, lastDrawing, gridArea;
        private Grid grid;
        private int gridSize;
        private IDraw objectDraw;
        private TransformMatrices tm;

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
            MessageBox.Show(grid.GetOrigin.ToString());
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

                if (cekTransform.Checked)
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

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (cekTransform.Checked && objectDraw != null && rbPolygon.Checked)
            {
                IDraw transform = ((ITransformation)objectDraw).Transform(tm.GetRotation(-Math.PI/2));
                using (Graphics g = Graphics.FromImage(drawingArea))
                {
                    transform.Draw(g);
                }

                pnlDrawingArea.Invalidate();

            }
        }

        private void cekTransform_CheckedChanged(object sender, EventArgs e)
        {
            if (cekTransform.Checked)
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
