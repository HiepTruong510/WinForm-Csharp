using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Size s = Screen.FromPoint.Size;
             Size s = Screen.PrimaryScreen.Bounds.Size;
            pictureBox1.Location = new Point(0, 0);
            Bitmap bm = new Bitmap(s.Width,s.Height);
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(0, 0, 0, 0, s);
            pictureBox1.Size = bm.Size;
           
          
          
            pictureBox1.Image = bm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
