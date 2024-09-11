using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form8 : Form
    {

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 31; i++)
                chonngay.Items.Add(i);
            chonngay.SelectedIndex = 0;
            for (int i = 1; i <= 12; i++)
                chonthang.Items.Add(i);
            for (int i = 1930; i <= 2010; i++)
                chonnam.Items.Add(i);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ngaymax;

            int ngay = int.Parse(chonngay.SelectedItem.ToString());
            int thang = int.Parse(chonthang.SelectedItem.ToString());
             int nam = int.Parse(chonnam.SelectedItem.ToString());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ngaymax = 31;
                    break;
                case 2:
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                        ngaymax = 29;
                    else
                        ngaymax = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ngaymax = 30;
                    break;
            }

            if (ngay <= 0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
            else
            {
                MessageBox.Show(textBox1.Text + " :" + ngay + "/" + thang + "/" + nam);
            }
        }
    }
}
