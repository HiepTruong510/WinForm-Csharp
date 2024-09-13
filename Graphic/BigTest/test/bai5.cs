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
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }
        
        private void bai5_Load(object sender, EventArgs e)
        {
            string text = "Tìm kiếm sự ủng hộ từ phía những người khác";
            Font font = new Font("Mistral", 20);
            // Tạo một hình bitmap trong-bộ-nhớ.
            Bitmap b = new Bitmap(600, 600);
            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(Brushes.AliceBlue, new Rectangle(0, 0, b.Width,
            b.Height));
            // Vẽ nhiều dòng text lên hình bitmap.
            for (int i = 0; i < 10; i++)
            {
               
            g.DrawString(text, font, Brushes.Black, 10, 10 + i * 60);
            }
            // Hiển thị hình bitmap trong PictureBox.
            pictureBox2.BackgroundImage = b;
            pictureBox2.Size = b.Size;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
