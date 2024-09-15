using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace form
{
    public partial class ListHD : Form
    {
        public ListHD()
        {
            InitializeComponent();
        }
        private void ListHD_Load(object sender, EventArgs e)
        {
            ListView_Init();
            Article_LoadData();
        }
        #region [ Design Layout ]
        private void ListView_Init()
        {
            ListView LV = LV_Data;

            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Autokey";
            colHead.Width = 36;
            colHead.TextAlign = HorizontalAlignment.Center;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "MaHD";
            colHead.Name = "MaHD";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ngayxuat";
            colHead.Name = "Ngayxuat";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "B_donvi";
            colHead.Name = "B_donvi";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "B_diachi";
            colHead.Name = "B_diachi";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "B_stk";
            colHead.Name = "B_stk";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "B_sdt";
            colHead.Name = "B_sdt";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "M_hoten";
            colHead.Name = "M_hoten";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "M_donvi";
            colHead.Name = "M_donvi";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "M_diachi";
            colHead.Name = "M_diachi";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "M_stk";
            colHead.Name = "M_stk";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "M_sdt";
            colHead.Name = "M_sdt";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Hinhthucthanhtoan";
            colHead.Name = "Hinhthucthanhtoan";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Tongtienhang";
            colHead.Name = "Tongtienhang";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Thue";
            colHead.Name = "Thue";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Tienthue";
            colHead.Name = "Tienthue";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Tongthanhtoan";
            colHead.Name = "Tongthanhtoan";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Manguoimua";
            colHead.Name = "Manguoimua";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Manguoiban";
            colHead.Name = "Manguoiban";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "RecordStatus";
            colHead.Name = "RecordStatus";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "CreatedOn";
            colHead.Name = "CreatedOn";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "CreatedBy";
            colHead.Name = "CreatedBy";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "CreatedName";
            colHead.Name = "CreatedName";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "ModifiedOn";
            colHead.Name = "ModifiedOn";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "ModifiedBy";
            colHead.Name = "ModifiedBy";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "ModifiedName";
            colHead.Name = "ModifiedName";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);


            LV.FullRowSelect = true;
            LV.GridLines = true;
            LV.View = View.Details;
        }
        #endregion


        private void Article_LoadData()
        {
            this.Cursor = Cursors.WaitCursor;
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;

            LV_Data.Items.Clear();
             DataTable zTable = HHT_Lib.Stock.Article_Data.List("MaHD", 1, 10);
           // DataTable zTable = HHT_Lib.Stock.Article_Data.List("MaHD");
            int n = zTable.Rows.Count;
            Random zRank = new Random();
            for (int i = 0; i < n; i++)
            {
                DataRow zRow = zTable.Rows[i];
                lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();
                lvi.Tag = zRow["Autokey"].ToString(); // Set the tag to 
                //lvi.ForeColor = Color.DarkBlue;
                lvi.BackColor = Color.White;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Autokey"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["MaHD"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Ngayxuat"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["B_donvi"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["B_diachi"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["B_stk"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["B_sdt"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["M_hoten"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["M_donvi"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["M_diachi"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["M_stk"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["M_sdt"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Hinhthucthanhtoan"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Tongtienhang"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Thue"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Tienthue"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Tongthanhtoan"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Manguoimua"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["Manguoiban"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["RecordStatus"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["CreatedOn"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["CreatedBy"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["CreatedName"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["ModifiedOn"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["ModifiedBy"].ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = zRow["ModifiedName"].ToString();
                lvi.SubItems.Add(lvsi);


                LV_Data.Items.Add(lvi);

            }
            this.Cursor = Cursors.Default;

        }

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            string zKey = LV_Data.SelectedItems[0].Tag.ToString();
            Hoadon frm = new Hoadon();
            frm.Autokey = zKey;
            frm.ShowDialog();
            Article_LoadData();
        }

      
    }
}
