using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truyenvaodatagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // các thuộc tính để lúc chạy chương trình ưa nhìn hơn , có thể không làm 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string duongdan;
            duongdan = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(duongdan);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            dataGridView1.ColumnCount =bitmap.Width;
            dataGridView1.RowCount = bitmap.Height;
            for (int x = 0; x < bitmap.Width; x++)
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    dataGridView1.Rows[i].Cells[x].Value = pixel.A;
                    
                }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            dataGridView2.ColumnCount = bitmap.Width;
            dataGridView2.RowCount = bitmap.Height;
            for (int x = 0; x < bitmap.Width; x++)
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    dataGridView2.Rows[i].Cells[x].Value = pixel.R;
                }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            dataGridView3.ColumnCount = bitmap.Width;
            dataGridView3.RowCount = bitmap.Height;
            for (int x = 0; x < bitmap.Width; x++)
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    dataGridView3.Rows[i].Cells[x].Value = pixel.G;
                }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
           
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            dataGridView4.ColumnCount = bitmap.Width;
            dataGridView4.RowCount = bitmap.Height;
            for (int x = 0; x < bitmap.Width; x++)
                for (int i = 0; i < bitmap.Height; i++)
                {
                    Color pixel = bitmap.GetPixel(x, i);
                    dataGridView4.Rows[i].Cells[x].Value = pixel.B;
                }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {                    
            Bitmap newImage = new Bitmap(pictureBox1.Image.Width,pictureBox1.Image.Height);

            for (int x = 0; x < pictureBox1.Image.Width; x++)
                for (int i = 0; i < pictureBox1.Image.Height; i++)
                {
                    byte a = byte.Parse(dataGridView1.Rows[i].Cells[x].Value.ToString());
                    byte r = byte.Parse(dataGridView2.Rows[i].Cells[x].Value.ToString());
                    byte g = byte.Parse(dataGridView3.Rows[i].Cells[x].Value.ToString());
                    byte b = byte.Parse(dataGridView4.Rows[i].Cells[x].Value.ToString());

                    newImage.SetPixel(x, i, Color.FromArgb(a,r,g,b));
                }
            pictureBox2.Image = newImage;
        }
    }
}
// hoàn thành .