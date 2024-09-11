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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtHienthi_TextChanged(object sender, EventArgs e)
        {
            if(txtHienthi.Text.Trim() != "")
            btnView.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lbnHienThi.Text = txtHienthi.Text;
        }
    }
}
