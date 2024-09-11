using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combopicturre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadtenanh();
            
        }
        void loadtenanh()
        {
            comboBox1.DataSource = new List<string>() { "1.jpg", "2.png", "3.png", "4.png" };
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString());
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
