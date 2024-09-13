using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnchonImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string duongdan;
            duongdan = openFileDialog1.FileName;

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int w = int.Parse(textBox1.Text);
            int h = int.Parse(textBox2.Text);
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Bitmap newImage = new Bitmap(w, h);
            int x = int.Parse(textBox3.Text);
            int y = int.Parse(textBox4.Text);

            for (int j = 0; j < w; j++)
            {
                for (int i = 0; i < h; i++)
                {
                    Color pixel = bitmap.GetPixel(j + x, i + y);
                    byte a = pixel.A;
                    byte g = pixel.G;
                    byte b = pixel.B;
                    byte r = pixel.R;
                    newImage.SetPixel(j, i, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = newImage;

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void trangden_Click(object sender, EventArgs e)
        {
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
                pictureBox1.Image = TrangDen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 255;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar4.Value = 0;
        }
       
        int R = 0, G = 0, B = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Bitmap newImage = new Bitmap(bitmap.Width, bitmap.Height);
            int t = trackBar2.Value - R;
            int y = trackBar3.Value - G;
            int u = trackBar4.Value - B;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    int a = trackBar1.Value;

                    int r = pixel.R;
                    r = r + t;
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;

                    int g = pixel.G;
                    g = g + y;
                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;

                    int b = pixel.B;
                    b = b + u;
                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;

                    newImage.SetPixel(x, i, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox1.Image = newImage;
            R = trackBar2.Value;
            G = trackBar3.Value;
            B = trackBar4.Value;
        }

      
        public double Goc(int a, double d)
        {
            double h = (double)(a / d);
            return Math.Acos(h);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Bitmap newImage = new Bitmap(bitmap.Width, bitmap.Height);
            int toadoX = (int)(bitmap.Width / 2);
            int toadoY = (int)(bitmap.Height / 2);

            if (comboBox1.Text == "xoay phai")
            {
                for (int x = 0; x < toadoX; x++)
                {
                    for (int y = 0; y < toadoY; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(toadoX - x, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY - (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY - (int)((Math.Sin((phi) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                    }
                    for (int y = toadoY; y < bitmap.Height; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(y - toadoY, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY + (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY - (int)((Math.Cos((phi) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                    }
                }
                for (int x = toadoX; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < toadoY; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(toadoY - y, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY - (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 1) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 1) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }


                    }
                    for (int y = toadoY; y < bitmap.Height; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(x - toadoX, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY + (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 1) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 1) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                    }
                }
            }

            if(comboBox1.Text == "xoay trai")
            {
                for (int x = 0; x < toadoX; x++)
                {
                    for (int y = 0; y < toadoY; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(toadoY - y, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY - (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            H = toadoX - (int)((Math.Sin((phi) - goc - g)) * d);
                            N = toadoY + (int)((Math.Cos((phi) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                    }
                    for (int y = toadoY; y < bitmap.Height; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(toadoX - x, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY + (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY + (int)((Math.Sin((phi) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                    }
                }
                for (int x = toadoX; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < toadoY; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(x - toadoX, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY - (int)((Math.Cos((phi / 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 1) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 1) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }


                    }
                    for (int y = toadoY; y < bitmap.Height; y++)
                    {
                        double d = Math.Sqrt((double)((toadoX - x) * (toadoX - x) + (toadoY - y) * (toadoY - y)));
                        double goc = Goc(y - toadoY, d);
                        double go = double.Parse(xoay.Text);
                        double g = (go / 180) * 3.14;
                        double phi = 3.14;
                        int H, N;
                        Color pixel = bitmap.GetPixel(x, y);
                        byte a = pixel.A;
                        byte G = pixel.G;
                        byte b = pixel.B;
                        byte r = pixel.R;
                        if ((goc + g) < (phi / 2))
                        {
                            N = toadoY + (int)((Math.Sin((phi / 2) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi / 2) - goc - g)) * d);

                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi)
                        {
                            N = toadoY - (int)((Math.Cos((phi * 1) - goc - g)) * d);
                            H = toadoX + (int)((Math.Sin((phi * 1) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                          
                        }
                        else if ((goc + g) < phi * 1.5)
                        {
                            N = toadoY - (int)((Math.Sin((phi * 1.5) - goc - g)) * d);
                            H = toadoX - (int)((Math.Cos((phi * 1.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2)
                        {
                            N = toadoY + (int)((Math.Cos((phi * 2) - goc - g)) * d);
                            H = toadoX - (int)((Math.Sin((phi * 2) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                            newImage.SetPixel(H, N, Color.FromArgb(a, r, G, b));
                        }
                        else if ((goc + g) < phi * 2.5)
                        {
                            N = toadoY + (int)((Math.Sin((phi * 2.5) - goc - g)) * d);
                            H = toadoX + (int)((Math.Cos((phi * 2.5) - goc - g)) * d);
                            if (N < 0 || N >= newImage.Height || H < 0 || H >= newImage.Width)
                                continue;
                            newImage.SetPixel(H , N, Color.FromArgb(a, r, G, b));
                        }
                    }
                }
            }    
                pictureBox3.Image = newImage;
            Bitmap biitmap = (Bitmap)pictureBox1.Image;
            Bitmap bm = new Bitmap(biitmap.Width, biitmap.Height);

        }

    }

}

