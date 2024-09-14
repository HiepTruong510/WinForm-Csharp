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

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private GraphicsPath path;
        private GraphicsPath path1;
        private GraphicsPath path2;
        private GraphicsPath path3;
        private Pen b;
        private Pen a;
        private void Form1_Load(object sender, EventArgs e)
        {
            path = new GraphicsPath();
            path1 = new GraphicsPath();
            path2 = new GraphicsPath();
            path3 = new GraphicsPath();
            b = new Pen(Color.DeepSkyBlue);
            b.Width = 2.5f;
            a= new Pen(Color.DeepSkyBlue);
            a.Width = 3f;

            //path.AddPolygon(new Point[] { new Point(112, 115), new Point(125, 100), new Point(185, 100), new Point(172, 115) });

            //viền 
            path2.AddPolygon(new Point[] { new Point(100, 132), new Point(112, 120), new Point(100, 132) });
            path2.AddPolygon(new Point[] { new Point(112, 120), new Point(188, 120), new Point(112, 120) });
            path2.AddPolygon(new Point[] { new Point(188, 120), new Point(208, 100), new Point(188, 120) });
            path2.AddPolygon(new Point[] { new Point(288, 100), new Point(420, 100), new Point(208, 100) });
            path2.AddPolygon(new Point[] { new Point(420, 100), new Point(452, 136), new Point(420, 100) });
            path2.AddPolygon(new Point[] { new Point(452, 136), new Point(564, 136), new Point(452, 136) });
            path2.AddPolygon(new Point[] { new Point(564, 136), new Point(564, 476), new Point(564, 136) });
            path2.AddPolygon(new Point[] { new Point(564, 476), new Point(548, 488), new Point(564, 476) });
            path2.AddPolygon(new Point[] { new Point(548, 488), new Point(548, 668), new Point(548, 488) });
            path2.AddPolygon(new Point[] { new Point(548, 668), new Point(392, 668), new Point(548, 668) });
            path2.AddPolygon(new Point[] { new Point(392, 668), new Point(380, 656), new Point(392, 668) });
            path2.AddPolygon(new Point[] { new Point(380, 656), new Point(123, 656), new Point(380, 656) });
            path2.AddPolygon(new Point[] { new Point(123, 656), new Point(100, 632), new Point(123, 656) });
            path2.AddPolygon(new Point[] { new Point(100, 632), new Point(100, 500), new Point(100, 632) });
            path2.AddPolygon(new Point[] { new Point(100, 500), new Point(116, 488), new Point(100, 500) });
            path2.AddPolygon(new Point[] { new Point(116, 488), new Point(116, 328), new Point(116, 488) });
            path2.AddPolygon(new Point[] { new Point(116, 328), new Point(100, 316), new Point(116, 328) });
            path2.AddPolygon(new Point[] { new Point(100, 316), new Point(100, 132), new Point(100, 316) });



            //path.addpolygon(new point[] { new point(100, 132), new point(112, 120), new point(188,120)
            //    , new point(208,100), new point(420,100), new point(452,136), new point(564,136), new point(564,476)
            //    , new point(548,488), new point(548,668), new point(392,668), new point(380,656)
            //    , new point(123,656), new point(100,632), new point(100,500), new point(116, 488), new point(116,328)
            //    , new point(100,316), new point(100,132)
            //});
            path.AddPolygon(new Point[] { new Point(106, 163), new Point(118, 150), new Point(195,150)
                , new Point(214,130), new Point(429,130), new Point(461,166), new Point(574,166), new Point(574,508)
                , new Point(558,520), new Point(558,700), new Point(399,700), new Point(387,688)
                , new Point(129,688), new Point(106,664), new Point(106,530), new Point(122, 518), new Point(122,359)
                , new Point(106,347), new Point(106,163)
            });  
         




            // ô xanh
            path1.AddPolygon(new Point[] { new Point(114,117), new Point(185,117), new Point(201,100), new Point(130, 100) });
            path.AddPolygon(new Point[] { new Point(120, 147), new Point(192, 147), new Point(208, 130), new Point(136, 130) });

            
            path1.AddPolygon(new Point[] { new Point(429, 100), new Point(445, 100), new Point(472, 130), new Point(456, 130) });
            path.AddPolygon(new Point[] { new Point(435, 130), new Point(454, 130), new Point(484, 163), new Point(464, 163) });

            path1.AddPolygon(new Point[] { new Point(457, 100), new Point(473, 100), new Point(500, 130), new Point(484, 130) });
            path.AddPolygon(new Point[] { new Point(463, 130), new Point(482, 130), new Point(512, 163), new Point(493, 163) });

            path1.AddPolygon(new Point[] { new Point(485, 100), new Point(501, 100), new Point(528, 130), new Point(512, 130) });
            path.AddPolygon(new Point[] { new Point(491, 130), new Point(510, 130), new Point(540, 163), new Point(521, 163) });

            path1.AddPolygon(new Point[] { new Point(513, 100), new Point(529, 100), new Point(556, 130), new Point(540, 130) });
            path.AddPolygon(new Point[] { new Point(519, 130), new Point(538, 130), new Point(568, 163), new Point(549, 163) });


            path1.AddPolygon(new Point[] { new Point(126, 662), new Point(376, 662), new Point(385, 668), new Point(135, 668) });
            path.AddPolygon(new Point[] { new Point(134, 690), new Point(383, 690), new Point(391, 700), new Point(143, 700) });


            //
            path1.AddPolygon(new Point[] { new Point(100,324), new Point(100,492), new Point(110, 485),new Point(110,332) });
            path.AddPolygon(new Point[] { new Point(106, 352), new Point(106, 525), new Point(120, 515), new Point(120, 362) });
            path3.AddPolygon(new Point[] { new Point(102, 328), new Point(102, 487), new Point(108, 483), new Point(108,333) });

            path1.AddPolygon(new Point[] { new Point(218, 110), new Point(408, 110), new Point(418, 120), new Point(208, 120) });
            path3.AddPolygon(new Point[] { new Point(220, 112), new Point(407, 113), new Point(413, 118), new Point(213, 118) });

            path1.AddPolygon(new Point[] { new Point(554, 492), new Point(554, 668), new Point(564, 668), new Point(564, 485) });
            path.AddPolygon(new Point[] { new Point(561, 522), new Point(561, 700), new Point(574, 700), new Point(574, 512) });
            path3.AddPolygon(new Point[] { new Point(556, 494), new Point(556, 666), new Point(562, 666), new Point(562, 489) });

            path1.AddPolygon(new Point[] { new Point(100, 642), new Point(100, 668), new Point(126, 668) });
            path.AddPolygon(new Point[] { new Point(106, 669), new Point(106, 700), new Point(136, 700) });
            path3.AddPolygon(new Point[] { new Point(102, 647), new Point(102, 666), new Point(120, 666) });





            
            this.Region = new Region(path);
          
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawPath(b, path2);
           
            g.DrawPath(b, path1);
            
            g.FillPath(Brushes.DeepSkyBlue, path1);
            g.FillPath(Brushes.Red, path3);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





























