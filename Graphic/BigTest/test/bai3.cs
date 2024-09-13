using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }
        

        private void bai3_Load(object sender, EventArgs e)
        {
            label1.Text = "TN SOLUTION";
            label1.Font = new Font("Microsoft Sans Serif", 20);
            label1.ForeColor = Color.Blue;
            GraphicsPath path = new GraphicsPath();
            Point[] pointsA = new Point[] {new Point(100, 0),new Point(0, 60),
            new Point(0,80), new Point(200,100)};
            path.AddCurve(pointsA);
            Point[] pointsB = new Point[]
                {
                new Point(this.Width - 40, this.Height - 60),
                new Point(this.Width, this.Height),
                new Point(10, this.Height)
                };
           path.AddCurve(pointsB);
            path.AddEllipse(123, 312, 100, 100);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
