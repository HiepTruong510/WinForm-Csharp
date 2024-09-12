using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = x2.Text + "X^2 + " + x1.Text + "X + " + x0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(x2.Text.ToString());
            int b = int.Parse(x1.Text.ToString());
            int c = int.Parse(x0.Text.ToString());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        label2.Text = "Phuong trinh co vo so nghiem";
                    else
                        label2.Text = "Phuongtrinh vo nghiem";
                }
                else
                {
                    label2.Text = "Nghiem cua phuong trinh la:";
                    ketqua.Text = "X = " + ((1.0 * -c / b).ToString());
                }
             }
            
            else
            {
                int denta = b * b - 4 * a * c;
                if (denta > 0)
                {
                    label2.Text = "Phuong trinh co hai nghiem phan biet:";
                    ketqua.Text = "X1 = " + ((1.0 * (-b + Math.Sqrt(denta)) / (2 * a)).ToString());
                    textBox5.Text = "X2 = " + ((1.0 * (-b - Math.Sqrt(denta))).ToString());
                }
                else if (denta == 0)
                {
                    label2.Text = "Phuowng trinh co nghiem kep: ";
                    ketqua.Text = "X = "+ ((1.0 * -b / (2 * a)).ToString());
                }
                else
                    label2.Text =  "Phuong trinh vo nghiem" ;

            }
        }

        
    }
}
