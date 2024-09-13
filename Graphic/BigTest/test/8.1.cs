using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace test
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo tập hợp font.
            InstalledFontCollection fontFamilies =
            new InstalledFontCollection();
            // Duyệt qua tất cả các font.
            int offset = 5;
            foreach (FontFamily family in fontFamilies.Families)
            {
                try
                {
                    // Tạo một Label để hiển thị text (viết ở font này).
                    Label fontLabel = new Label();
                    fontLabel.Text = family.Name;
                    fontLabel.Font = new Font(family, 14);
                    fontLabel.Left = 1;
                    fontLabel.Width = pnlFonts.Width;
                    fontLabel.Top = offset;
                    // Thêm Label vào Panel cuộn được.
                    pnlFonts.Controls.Add(fontLabel);
                    offset += 30;
                }
                catch
                {
                    // Lỗi sẽ xảy ra nếu font được chọn không
                    // hỗ trợ normal style (mặc định được sử dụng khi
                    // tạo đối tượng Font). Vấn đề này có thể
                    // được bỏ qua mà không sao cả.
                }
            }
        }
    }
}
