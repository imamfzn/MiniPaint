using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class frmTransformationSetting : Form
    {
        public TransformOption opt { get; set; }

        public frmTransformationSetting()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int dx = Convert.ToInt32(numDx.Value), 
                dy = Convert.ToInt32(numDy.Value);

            Double k = Convert.ToDouble(numKFactor.Value), 
                alpha = Convert.ToDouble(numAlpha.Value) * Math.PI / 180,
                m = Convert.ToDouble(numGrad.Value), 
                c = Convert.ToDouble(numConst.Value);
            
            if (rbRefLine2.Checked)
            {
                m = Double.PositiveInfinity;
            }

            opt = new TransformOption(dx, dy, k, alpha, m, c);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
