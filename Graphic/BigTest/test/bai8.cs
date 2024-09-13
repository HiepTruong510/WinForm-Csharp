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
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }
        Image thumbnail;
        private void bai8_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\ACER\Pictures\Saved Pictures\Gaming_5000x3125.jpg");
            int thumbnailWidth = 0, thumbnailHeight = 0;
            // Điều chỉnh chiều lớn hơn là 50 pixel.
            // Việc này bảo đảm thumbnail sẽ không lớn hơn 50x50 pixel.
            // Nếu muốn hiển thị nhiều thumbnail, bạn sẽ phải dùng
            // một hình vuông 50x50 pixel cho mỗi thumbnail.
            if (img.Width > img.Height)
            {
                thumbnailWidth = 500;
                thumbnailHeight = Convert.ToInt32(((500F / img.Width) *
                img.Height));
            }
            else
            {
                thumbnailHeight = 500;
                thumbnailWidth = Convert.ToInt32(((500F / img.Height) *
                img.Width));
            }
            thumbnail = img.GetThumbnailImage(thumbnailWidth,
            thumbnailHeight, null, IntPtr.Zero);
        }

        private void bai8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(thumbnail, 10, 10);
        }
    }
}
