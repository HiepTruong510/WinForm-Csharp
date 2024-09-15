using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xamsangmau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string duongdan;
            duongdan = openFileDialog1.FileName;

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = false;
            //-------------------------------------------//
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Bitmap TrangDen = new Bitmap(bitmap.Width, bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    byte b = pixel.B;
                    byte g = pixel.G;
                    byte r = pixel.R;
                    byte xam = (byte)((r + g + b) / 3);
                    TrangDen.SetPixel(x, i, Color.FromArgb(xam, xam, xam));
                }
           
            }
            pictureBox2.Image = TrangDen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        public void ha(int j)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Bitmap mau = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    byte b = pixel.B;
                    byte g = pixel.G;
                    byte r = pixel.R;
                    byte xam = (byte)((r + g + b) / 3);
                    int b2 = (int)(b - xam) / 10;
                    int r2 = (int)(r - xam) / 10;
                    int g2 = (int)(g - xam) / 10;

                    mau.SetPixel(x, i, Color.FromArgb(xam + r2 * j, xam + g2 * j, xam + b2 * j));

                    pictureBox2.Image = mau;

                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();         
        }
        int j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j > 8)
                timer1.Stop();
            j = j + 1;
            ha(j);
            
           
        }
    }
}
