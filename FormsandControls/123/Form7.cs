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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void moveone_Click(object sender, EventArgs e)
        {
            if (MatHang.SelectedItems.Count !=0)
            {
                DaChon.Items.Add(MatHang.SelectedItem);
                MatHang.Items.Remove(MatHang.SelectedItem);
            }
        }

        private void moveall_Click(object sender, EventArgs e)
        {
            int n = MatHang.Items.Count;
            for (int i=0; i<n;i++ )
            {
                DaChon.Items.Add(MatHang.Items[i]);
                //MatHang.Items.Remove(MatHang.Items[i])
            }
            for (int i = n-1; i >=0; i--)
            {
                MatHang.Items.Remove(MatHang.Items[i]);
            }
        }

        private void removeone_Click(object sender, EventArgs e)
        {
            if (DaChon.SelectedItems.Count != 0)
            {
                MatHang.Items.Add(DaChon.SelectedItem);
                DaChon.Items.Remove(DaChon.SelectedItem);
            }
        }

        private void removeall_Click(object sender, EventArgs e)
        {
            int n = DaChon.Items.Count;
            for (int i = 0; i < n; i++)
            {
                MatHang.Items.Add(DaChon.Items[i]);
                //MatHang.Items.Remove(MatHang.Items[i])
            }
            for (int i = n - 1; i >= 0; i--)
            {
                DaChon.Items.Remove(DaChon.Items[i]);
            }
        }
    }
}
 