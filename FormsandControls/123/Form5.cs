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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strKetQua = "";
            if (checkBox1.Checked)
                strKetQua = strKetQua + checkBox1.Text + '\n';
            if (checkBox2.Checked)
                strKetQua = strKetQua + checkBox2.Text + '\n';
            if (checkBox3.Checked)
                strKetQua = strKetQua + checkBox3.Text + '\n';
            if (checkBox4.Checked)
                strKetQua = strKetQua + checkBox4.Text + '\n';
            if (checkBox5.Checked)
                strKetQua = strKetQua + checkBox5.Text + '\n';
            if (strKetQua == "")
                lbKetQua.Text = "Bạn không lựa chọn ca sĩ nào trong danh sách trên";
            else
                lbKetQua.Text = "Các ca sĩ mà bạn yêu thích là:\n " + strKetQua;
        }
    }
}
