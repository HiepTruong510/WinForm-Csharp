using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vẽ_ảnh_thầy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bm = new Bitmap(640,480);
        public void chaytrucx(int x1, int y1, int x2, int y2)
        {
            for (int i = x1; i <= x2; i++)
            {
                int j;
                j = ((i - x1) * (y2 - y1) / (x2 - x1)) + y1;
                bm.SetPixel(i, j, Color.Black);
            }
        }
        public void chaytrucy(int x1, int y1, int x2, int y2)
        {
            for (int i = y1; i <= y2; i++)
            {
                int j;
                j = ((i - y1) * (x2 - x1) / (y2 - y1)) + x1;
                bm.SetPixel( j, i, Color.Black);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chaytrucx(73, 20, 304, 183);
            chaytrucx(354, 184, 575, 36);

            chaytrucx(102, 41, 549, 55);
            chaytrucx(131, 62, 517, 75);
            chaytrucx(155, 78, 495, 90);

            chaytrucx(177, 95, 269, 94);
            chaytrucx(387, 98, 476, 100);

            chaytrucx(192, 103, 460, 110);
            chaytrucx(203, 112, 448, 118);
            chaytrucx(217, 121, 441, 126);
            chaytrucx(230, 127, 430, 132);
            chaytrucx(234, 132, 420, 139);
            chaytrucx(246, 141, 410, 145);
            chaytrucx(253, 146, 398, 154);
            chaytrucx(262, 155, 390, 158);
            chaytrucx(270, 159, 385, 161);
            chaytrucx(275, 162, 379, 165);
            chaytrucx(275, 166, 374, 168);
            chaytrucx(284, 170, 371, 171);
            chaytrucx(291, 175, 364, 176);
            chaytrucx(297, 179, 356, 180);
            chaytrucx(300, 182, 360, 183);



            chaytrucx(41,176,221,190);
            chaytrucx(222,191,244,191);
            chaytrucx(244,190,277,193);
            chaytrucx(278,195,307,196);


            chaytrucx(477, 190,604, 182);
            chaytrucx(440, 194,472, 194);
            chaytrucx(425, 194, 440, 193);
            chaytrucx(348, 196, 425, 195);
            //trai
            chaytrucx(33,441,220,289);
            chaytrucx(222,266,243,267);
            chaytrucx(243,267,277,240);
            chaytrucx(277,236,285,236);
            chaytrucx(285,236,304,220);

            chaytrucx(53,445,220,296);
            chaytrucx(220,272,245,272);
            chaytrucx(245,272,277,243);
            chaytrucx(277,239,287,239);
            chaytrucx(287,239,303,222);

            chaytrucx(33,441,53,445);

            chaytrucx(222, 140, 246, 140);
            chaytrucx(441, 129, 476, 127);
            chaytrucx(419, 139, 429, 139);
            chaytrucx(277, 171, 285, 172);


            for (int i = 289; i <= 296; i++)
            {
                
                chaytrucx(33,441, 220, i);
                chaytrucx( 53,445, 220, i);
            }
            for (int i = 33; i <= 53; i++)
            {
                int j;
                j = ((i - 33) * (4) / (20)) + 441;
                chaytrucx(i, j, 219, 289);
                chaytrucx(i, j, 220, 296);
            }

            for (int i = 267; i <= 272; i++)
            {

                for (int j= 221; j <= 244; j++)
                {

                    bm.SetPixel( j, i, Color.Black);
                }
            }

            for (int i = 267; i <= 272; i++)
            {

                chaytrucx(245,i,277,243);
                chaytrucx(245, i,277,240);
            }
            for (int i = 240; i <= 243; i++)
            {

                chaytrucx(245,272, 277, i);
                chaytrucx(243,267, 277, i);
            }

            for (int i = 236; i <= 239; i++)
            {

                for (int j = 277; j <= 285; j++)
                {

                    bm.SetPixel(j, i, Color.Black);
                }
            }


            for (int i = 219; i <= 222; i++)
            {

                chaytrucx(304, i, 311, i);
            }
            for (int i = 236; i <= 239; i++)
            {

                chaytrucx(286, i, 304, 220);
                chaytrucx(286, i, 308, 220);
            }

            for (int i = 189; i <= 220; i++)
            {

                chaytrucx(308, i, 311, i);
            
            }
            for (int i = 188; i <= 190; i++)
            {

                chaytrucx(308, i, 349, i);

            }

            for (int i = 189; i <= 220; i++)
            {

                chaytrucx(346, i, 349, i);

            }
            for (int i = 219; i <= 222; i++)
            {

                chaytrucx(346, i, 353, i);
            }

            //phai
            chaytrucx(580, 450, 596, 446);

            chaytrucx(351, 224, 416, 285);
            chaytrucx(416, 285, 424, 285);
            chaytrucx(422, 292, 437, 303);
            chaytrucx(437, 303, 471, 305);
            chaytrucx(473, 341, 580, 450);

            chaytrucx(352, 222, 417, 280);
            chaytrucx(417, 280, 422, 280);
            chaytrucx(423, 288, 438, 297);
            chaytrucx(438, 297, 472, 299);
            chaytrucx(472, 329, 596, 446);

            for (int i = 222; i <= 224; i++)
            {

                chaytrucx(351,i, 416,285);
                chaytrucx(351,i,417,280);
            }
            for (int i = 280; i <= 285; i++)
            {

                chaytrucx(350,220,417,i);
              
            }

            for (int i = 417; i <= 423; i++)
            {

               chaytrucy(i, 281, i,285);

            }

            for (int i = 288; i <= 293; i++)
            {

                chaytrucx(423,i,437,303);
                chaytrucx(423, i, 438, 297);

            }
            for (int i = 297; i <= 303; i++)
            {

                chaytrucx(423, 292, 437,i);
                chaytrucx(423, 288, 438,i);

            }


            for (int i = 297; i <= 303; i++)
            {

                chaytrucx(438,i, 472, i);

            }
            for (int i = 329; i <= 341; i++)
            {

                chaytrucx(473, i, 580, 450);
                chaytrucx(473, i, 596, 446);

            }
            for (int i = 580; i <=596; i++)
            {
                int j;
                j = ((i - 580) * (-4) / (16)) + 450;
                chaytrucx(473, 329,i, j);
                chaytrucx(473, 341,i, j) ;
            }




            // ô vuông 
            chaytrucy( 304, 185,303, 220);
            chaytrucx(304, 185, 353, 184);
            chaytrucy(353, 184, 352, 221);
            chaytrucx(303, 220, 309, 220);
            chaytrucy(309, 190, 309, 220);
            chaytrucx(346, 221, 352, 221);
            chaytrucy(348, 191, 348, 221);
            chaytrucx(309, 189, 348, 189);

            chaytrucx(319, 209, 337, 209);
            chaytrucy(319, 192, 319, 209);
            chaytrucy(337, 192, 337, 209);
            chaytrucx(319, 192, 337, 192);
            chaytrucy(328, 192, 328, 209);

            chaytrucx(309, 220, 320, 209);
            chaytrucx(336, 209, 348, 221);

            // phong trai
            chaytrucy(221,124,219,188);
            chaytrucy(222, 191, 220, 297);

            chaytrucy(245, 140, 244, 272);

            chaytrucy(277, 167, 276, 193);
            chaytrucy(278, 194, 276, 245);

            chaytrucy(286, 171, 286, 239);

            // tran
            chaytrucy(224, 23, 319, 183);
            chaytrucy(430, 28, 338, 183);
            chaytrucy(263, 81, 271, 95);

            chaytrucx(263, 95, 318, 97);

            chaytrucx(318, 97, 325, 99);
            chaytrucx(325, 99, 335, 100);
            chaytrucx(335, 100, 340, 101);
            chaytrucx(340, 101, 350, 100);
            chaytrucx(350, 100, 387, 97);
            //phong pahii
            chaytrucy(474, 191, 471, 340);
            chaytrucy(477, 100, 475, 189);

            chaytrucy(440, 125, 440, 194);
            chaytrucy(439, 195, 437, 303);

            chaytrucy(428, 133, 427, 195);
            chaytrucy(425, 195, 423, 293);

            chaytrucy(420, 140, 419, 195);
            chaytrucy(418, 197, 417, 285);


            // 
            chaytrucy(574, 226, 571, 366);

            chaytrucy(545, 222, 546, 237);
            chaytrucy(546, 237, 544, 240);
            chaytrucy(544, 240, 540, 282);
            chaytrucy(540, 282, 544, 326);
            chaytrucy(544, 326, 545, 336);
            chaytrucy(545, 336, 544, 348);

            chaytrucx(544, 348, 571, 366);
            chaytrucx(545, 336, 571, 354);
            chaytrucx(546, 237, 573, 237);
            chaytrucx(545, 222, 574, 226);

            chaytrucx(560, 251, 573, 249);
            chaytrucx(560, 329, 572, 335);
            chaytrucy(562, 250, 558, 290);
            chaytrucy(558, 290, 562, 330);
            chaytrucx(546, 242, 562, 248);
            chaytrucx(544, 328, 564, 332);

            chaytrucx(549, 279, 555, 278);
            chaytrucy(549, 279, 547, 292);
            chaytrucx(547, 292, 554, 295);























            pictureBox1.Image = bm;
        }
    }
}
