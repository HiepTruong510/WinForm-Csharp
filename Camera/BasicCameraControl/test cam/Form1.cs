using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace test_cam
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public Form1()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice  ); // các camera đang hoạt động trên máy
            foreach(FilterInfo a in cameras)
            {
                comboBox1.Items.Add(a.Name);
            }
            comboBox1.SelectedIndex = 0;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            
        }   

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;
            saveFileDialog1.ShowDialog();
            saveFileDialog1.FileName = 5.ToString();
            pictureBox1.Image.Save(saveFileDialog1.FileName );


        }
        int j = 0;
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            j++;
            //saveFileDialog1.FileName = j.ToString();
            pictureBox1.Image.Save("aa" + j.ToString());
            if (j > 9)
                timer1.Stop();
        }
    }
}
