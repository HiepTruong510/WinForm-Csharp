using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }
        unsafe
        private void Button1_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)pictureBox1.Image;
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
            int next = data.Stride - bitmap.Width * 3;
         
            byte* p =(byte*) data.Scan0;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int t = (p[0] + p[1] + p[2]) / 3;
                    p[0] = (byte)t;
                    p[1] = (byte)t;
                    p[2] = (byte)t;
                    p += 3;

                }
                p += next;
            }
            bitmap.UnlockBits(data);
            pictureBox1.Image = bitmap;
        }
    }
}
