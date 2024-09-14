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

namespace _1piont
{
    public partial class Form1 : Form
    {
        private GraphicsPath path;
        private Rectangle diem;
        //private Pen b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diem = new Rectangle(599, 229, 3, 3);

            path = new GraphicsPath();
            path.AddRectangles(new Rectangle[]
            {
                new Rectangle(0,0,1200,800),//nhà
                //new Rectangle(320,120,14*40,400),// tường đối diện
                new Rectangle(480,160,240,140),// ảnh trong
                new Rectangle(475,155,250,150), // ảnh ngoài 
                new Rectangle(530,190,140,80),
                new Rectangle(475,460,250,20) ,//góc bàn 
                new Rectangle(475,480,15,140) ,//chân trc
                new Rectangle(710,480,15,140) ,
                new Rectangle(545,480,15,50), // chân sau
                new Rectangle(640,480,15,50),
              

            });
            //sàn r
            path.AddPolygon(new PointF[] { new PointF(320,520), new PointF(45,800), new PointF(320,520) });
            
            path.AddPolygon(new PointF[] { new PointF(360, 520), new PointF(130, 800), new PointF(360, 520) });
            path.AddPolygon(new PointF[] { new PointF(400, 520), new PointF(205, 800), new PointF(400, 520) });
            path.AddPolygon(new PointF[] { new PointF(440, 520), new PointF(285, 800), new PointF(440, 520) });
            path.AddPolygon(new PointF[] { new PointF(475, 525), new PointF(360, 800), new PointF(475, 525) });
            path.AddPolygon(new PointF[] { new PointF(520, 520), new PointF(440, 800), new PointF(520, 520) });

            path.AddPolygon(new PointF[] { new PointF(558, 530), new PointF(520, 800), new PointF(558, 530) });
            path.AddPolygon(new PointF[] { new PointF(600, 520), new PointF(600, 800), new PointF(600, 520) });
            path.AddPolygon(new PointF[] { new PointF(642, 530), new PointF(680, 800), new PointF(642, 530) });
            path.AddPolygon(new PointF[] { new PointF(680, 520), new PointF(760, 800), new PointF(680, 520) });
            path.AddPolygon(new PointF[] { new PointF(725, 525), new PointF(840, 800), new PointF(725, 525) });
            path.AddPolygon(new PointF[] { new PointF(760, 520), new PointF(915, 800), new PointF(760, 520) });
            path.AddPolygon(new PointF[] { new PointF(800, 520), new PointF(995, 800), new PointF(800, 520) });
            path.AddPolygon(new PointF[] { new PointF(840, 520), new PointF(1070, 800), new PointF(840, 520) });
            path.AddPolygon(new PointF[] { new PointF(880, 520), new PointF(1155, 800), new PointF(880, 520) });

            //bi cat
            path.AddPolygon(new PointF[] { new PointF(495, 520), new PointF(545, 520), new PointF(495, 520) });
            path.AddPolygon(new PointF[] { new PointF(655, 520), new PointF(705, 520), new PointF(655, 520) });
            path.AddPolygon(new PointF[] { new PointF(565, 520), new PointF(635, 520), new PointF(565, 520) });
            path.AddPolygon(new PointF[] { new PointF(320, 520), new PointF(475, 520), new PointF(320, 520) });
            path.AddPolygon(new PointF[] { new PointF(880, 520), new PointF(725, 520), new PointF(880, 520) });

            //path.AddPolygon(new PointF[] { new PointF(477, 620), new PointF(400, 800), new PointF(477,620) });
            //path.AddPolygon(new PointF[] { new PointF(520,520), new PointF(495, 582), new PointF(520,520) });

            //path.AddPolygon(new PointF[] { new PointF(723, 620), new PointF(800,800), new PointF(723,620) });
            //path.AddPolygon(new PointF[] { new PointF(680, 520), new PointF(705, 582), new PointF(680, 520) });

            //path.AddPolygon(new PointF[] { new PointF(312,800), new PointF(475, 530), new PointF(312,800) });
            //path.AddPolygon(new PointF[] { new PointF(888, 800), new PointF(725, 530), new PointF(888, 800) });
            // tran r
            path.AddPolygon(new PointF[] { new PointF(20,0), new PointF(320,120), new PointF(320+14*40,120), new PointF(1180,0) });
            //ảnh r
            path.AddPolygon(new PointF[] { new PointF(480, 160), new PointF(530, 190), new PointF(670,190), new PointF(720,160) });
            path.AddPolygon(new PointF[] { new PointF(480, 300), new PointF(530, 270), new PointF(670, 270), new PointF(720, 300) });
            //bàn r
            path.AddPolygon(new PointF[] { new PointF(545,330), new PointF(655,330), new PointF(725,460), new PointF(475, 460) });
            // sách r
            path.AddPolygon(new PointF[] { new PointF(610, 360), new PointF(655, 360), new PointF(675,410 ), new PointF(620,410) });
            path.AddPolygon(new PointF[] { new PointF(610, 360), new PointF(609, 370), new PointF(617, 415), new PointF(677, 415) , 
                new PointF(675,410), new PointF(620,410)  });
            path.AddPolygon(new PointF[] { new PointF(620, 410), new PointF(617, 415), new PointF(620, 410) });
            // chân r
            path.AddPolygon(new PointF[] { new PointF(490, 480), new PointF(495, 480), new PointF(495,600), new PointF(490,620) });
            path.AddPolygon(new PointF[] { new PointF(705, 480), new PointF(710, 480), new PointF(710, 620), new PointF(705, 600) });
            path.AddPolygon(new PointF[] { new PointF(560, 480), new PointF(565, 480), new PointF(565, 520), new PointF(560, 530) });//chansau
            path.AddPolygon(new PointF[] { new PointF(635, 480), new PointF(640, 480), new PointF(640,530), new PointF(635, 520) });
            //cửa sổ  r
            path.AddPolygon(new PointF[] { new PointF(920 + 15, 162 + 20), new PointF(1064 + 15, 120 + 40), new PointF(1064 + 15, 380 + 30), new PointF(920 + 15, 338 + 20) });
            path.AddPolygon(new PointF[] { new PointF(925 + 15, 165 + 20), new PointF(1059 + 15, 127 + 40), new PointF(1059 + 15, 373 + 30), new PointF(925 + 15, 335 + 20) });
            path.AddPolygon(new PointF[] { new PointF(925+40 + 15, 165+20 + 20), new PointF(1059 + 15, 127+35 + 35), new PointF(1059 + 15, 373-35 + 23), new PointF(925+40 + 15, 335-20 + 20) });
            path.AddPolygon(new PointF[] { new PointF(925 + 15, 165 + 20), new PointF(925 + 15 + 40, 165 + 20 + 20), new PointF(925 + 15, 165 + 20)  });
            path.AddPolygon(new PointF[] { new PointF(925 + 15, 335 + 20), new PointF(925 + 15 + 40, 335 - 20 + 20), new PointF(925 + 15, 335 + 20) });
            // cửa r
            path.AddPolygon(new PointF[] { new PointF(280, 158), new PointF(120, 120), new PointF(120, 724), new PointF(280, 561) });

            path.AddPolygon(new PointF[] { new PointF(270, 167), new PointF(140, 140), new PointF(140, 704), new PointF(270, 570) });
            path.AddPolygon(new PointF[] { new PointF(120,120), new PointF(110,120), new PointF(110,647), new PointF(120, 638) });
            //ốp r
            path.AddPolygon(new PointF[] { new PointF(120, 638), new PointF(0, 740), new PointF(120, 638) });
            path.AddPolygon(new PointF[] { new PointF(320, 470), new PointF(280, 505), new PointF(320, 470) });
            path.AddPolygon(new PointF[] { new PointF(320, 470), new PointF(475, 470), new PointF(320, 470) });
            path.AddPolygon(new PointF[] { new PointF(725, 470), new PointF(880, 470), new PointF(725, 470) });
            path.AddPolygon(new PointF[] { new PointF(880, 470), new PointF(1200, 740), new PointF(880, 470) });
            // công tắc
            path.AddPolygon(new PointF[] { new PointF(60,363), new PointF(90,355), new PointF(90,398), new PointF(60,408) });
            path.AddEllipse(70, 368 + 7, 10,10);
            path.AddEllipse(71, 369 + 7, 10, 10);
            path.AddEllipse(73, 371 + 7, 7, 7);
            // mở cửa +5
            path.AddEllipse(165, 400, 20, 20);
            path.AddEllipse(178, 403, 8, 15);
            path.AddEllipse(177, 403, 9, 15);
            path.AddEllipse(180, 409, 3,3 );
            path.AddEllipse(180, 409, 4, 4);
            path.AddPolygon(new PointF[] { new PointF(160, 406), new PointF(165, 406), new PointF(160,406) });
            path.AddPolygon(new PointF[] { new PointF(160, 414), new PointF(165, 414), new PointF(160, 414) });
            path.AddCurve(new Point[] {new Point(155,398),
            new Point(160,406), new Point(160,410), new Point(160,414), new Point(155,422)});
            //tường 
            path.AddPolygon(new PointF[] { new PointF(320, 120), new PointF(320, 520), new PointF(320, 120) });
            path.AddPolygon(new PointF[] { new PointF(880, 120), new PointF(880,520), new PointF(880,120) });
            
            path.CloseFigure();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Red, diem);
            g.DrawPath(Pens.Black, path);
        }
    }
}
