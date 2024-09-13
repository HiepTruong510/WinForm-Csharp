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
    public class EllipseShape : System.Windows.Forms.Control
    {
        private GraphicsPath path = null;
        private void RefreshPath()
        {
            // Tạo GraphicsPath cho shape và áp dụng nó vào
            // điều kiểm bằng cách thiết lập thuộc tính Region.
            path = new GraphicsPath();
            path.AddEllipse(this.ClientRectangle);
            this.Region = new Region(path);
        }
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            RefreshPath();
            this.Invalidate();
        }
        protected override void OnPaint
        (System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            if (path != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
                e.Graphics.DrawPath(new Pen(this.ForeColor, 4), path);
            }
        }
    }
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }
        // Các cờ dùng để theo vết chuột khi chế độ kéo rê được kích hoạt.
        private bool isDraggingA = false;
        private bool isDraggingB = false;
        // Các điều kiểm có hình dạng ellipse.
        private EllipseShape ellipseA, ellipseB;

        private void bai4_Load(object sender, EventArgs e)
        {
            // Tạo và cấu hình cả hai ellipse.
            ellipseA = new EllipseShape();
            ellipseA.Width = ellipseA.Height = 100;
            ellipseA.Top = ellipseA.Left = 30;
            ellipseA.BackColor = Color.Red;
            this.Controls.Add(ellipseA);
            ellipseB = new EllipseShape();
            ellipseB.Width = ellipseB.Height = 100;
            ellipseB.Top = ellipseB.Left = 130;
            ellipseB.BackColor = Color.Azure;
            this.Controls.Add(ellipseB);
            // Gắn cả hai ellipse vào cùng tập các phương thức
            // thụ lý sự kiện.
            ellipseA.MouseDown += new MouseEventHandler(Ellipse_MouseDown);
            ellipseA.MouseUp += new MouseEventHandler(Ellipse_MouseUp);
            ellipseA.MouseMove += new MouseEventHandler(Ellipse_MouseMove);
            ellipseB.MouseDown += new MouseEventHandler(Ellipse_MouseDown);
            ellipseB.MouseUp += new MouseEventHandler(Ellipse_MouseUp);
            ellipseB.MouseMove += new MouseEventHandler(Ellipse_MouseMove);
        }
        private void Ellipse_MouseDown(object sender, MouseEventArgs e)
        {
            // Thu lấy ellipse gây ra sự kiện này.
            Control control = (Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                control.Tag = new Point(e.X, e.Y);
                if (control == ellipseA)
                {
                    isDraggingA = true;
                }
                else
                {
                    isDraggingB = true;
                }
            }
        }
        private void Ellipse_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingA = false;
            isDraggingB = false; 
       
        }
        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            // Thu lấy ellipse gây ra sự kiện này.
            Control control = (Control)sender;
            if ((isDraggingA && control == ellipseA) ||
            (isDraggingB && control == ellipseB))
            {
                // Lấy offset.
                Point point = (Point)control.Tag;
                // Di chuyển điều kiểm.
                control.Left = e.X + control.Left - point.X;
                control.Top = e.Y + control.Top - point.Y;
            }
        }
    }
}
