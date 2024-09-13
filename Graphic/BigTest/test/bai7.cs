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
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }
        private bool isShrinking = false;
        private int imageSize = 0;
        // Lưu trữ logo sẽ được vẽ lên form.
        private Image image;
        private void bai7_Load(object sender, EventArgs e)
        {
            // Nạp bức hình logo từ file.
            image = Image.FromFile(@"D:\anh\gioi-thieu-ban-than-.jpg");
            // Khởi động Timer để làm mất hiệu lực form.
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Thay đổi kích thước bức hình dựa vào kiểu animation.
            if (isShrinking)
            {
                imageSize--;
            }
            else
            {
                imageSize++;
            }
            // Đổi hướng thay đổi kích thước nếu đến gần biên của form.
            if (imageSize > (this.Width - 150))
            {
                isShrinking = true;
            }
            else if (imageSize < 1)
            {
                isShrinking = false;
            }
            // Vẽ lại form.
            this.Invalidate();
        }

        private void bai7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            Bitmap drawing = null;
            if (checkBox1.Checked)
            {
                // "Double buffering" đang được sử dụng.
                // Tạo một bitmap trong-bộ-nhớ mô tả bề mặt của form.
                drawing = new Bitmap(this.Width, this.Height, e.Graphics);
                g = Graphics.FromImage(drawing);
            }
            else
            {
                
                g = e.Graphics;
            }
            g.SmoothingMode = SmoothingMode.HighQuality;
            // Vẽ nền.
            g.FillRectangle(Brushes.AntiqueWhite,
            new Rectangle(new Point(0, 0), this.ClientSize));
            // Vẽ bức hình logo.
            g.DrawImage(image, 50, 50, 50 + imageSize, 50 + imageSize);
            // Nếu sử dụng "double buffering", chép hình bitmap
            // đã hoàn tất trong bộ nhớ vào form.
            if (checkBox1.Checked)
            {
                e.Graphics.DrawImageUnscaled(drawing, 0, 0);
                g.Dispose();
            }
        }
        protected override void OnPaintBackground(
System.Windows.Forms.PaintEventArgs pevent)
        {
            // Không làm gì cả.
        }
    }
}
