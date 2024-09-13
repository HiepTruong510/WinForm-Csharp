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
    public partial class _8 : Form
    {
        public _8()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // _8
            // 
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Name = "_8";
            this.Load += new System.EventHandler(this._8_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this._8_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._8_MouseMove);
            this.ResumeLayout(false);

        }
        private GraphicsPath path;
        private Rectangle rectangle;
        
        // Định nghĩa các cờ để theo vết con trỏ chuột.
        private bool inPath = false;
        private bool inRectangle = false;
        // Định nghĩa các bút vẽ.
        Brush highlightBrush = Brushes.LightGreen;
        Brush defaultBrush = Brushes.LightBlue;

        private void _8_Load(object sender, EventArgs e)
        {
            // Tạo các shape.
            path = new GraphicsPath();
            path.AddEllipse(10, 10, 100, 60);
            path.AddCurve(new Point[] {new Point(50, 50),
            new Point(10,33), new Point(80,43), new Point(55,33)});
            path.AddLine(50, 120, 250, 80);
            path.AddLine(120, 40, 110, 50);
            
            path.CloseFigure();
            rectangle = new Rectangle(300, 10, 220, 120);
        }

        private void _8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Vẽ shape dựa trên phần chọn hiện tại.
            if (inPath)
            {
                g.FillPath(highlightBrush, path);
                g.FillRectangle(defaultBrush, rectangle);
            }
            else if (inRectangle)
            {
                g.FillRectangle(highlightBrush, rectangle);
                g.FillPath(defaultBrush, path);
            }
            else
            {
                g.FillPath(defaultBrush, path);
                g.FillRectangle(defaultBrush, rectangle);
            }
            g.DrawPath(Pens.Black, path);
            g.DrawRectangle(Pens.Black, rectangle);
        }

        private void _8_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            // Thực hiện "hit testing" với hình chữ nhật.
            if (rectangle.Contains(e.X, e.Y))
            {
                if (!inRectangle)
                {
                    inRectangle = true;
                    // Đổi màu nền hình chữ nhật.
                    g.FillRectangle(highlightBrush, rectangle);
                    g.DrawRectangle(Pens.Black, rectangle);
                }
               
            }
            else if (inRectangle)
            {
                inRectangle = false;
                g.FillRectangle(defaultBrush, rectangle);
                g.DrawRectangle(Pens.Black, rectangle);
                
            }
            // Thực hiện "hit testing" với path.
            if (path.IsVisible(e.X, e.Y))
            {
                if (!inPath)
                {
                    inPath = true;
                    // Đổi màu nền path.
                    g.FillPath(highlightBrush, path);
                    g.DrawPath(Pens.Black, path);
                }
            }
            else if (inPath)
            {
                inPath = false;
                // Phục hồi path.
                g.FillPath(defaultBrush, path);
                g.DrawPath(Pens.Black, path);
            }
            g.Dispose();
        }
    }
}
