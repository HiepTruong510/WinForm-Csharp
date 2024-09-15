using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HHT_Lib.Stock;

namespace form
{
    public partial class Hoadon : Form
    {
        private string _Autokey = "";
        private Article_Info _Article;
        public Hoadon()
        {
            InitializeComponent();
        }
        private void Hoadon_Load(object sender, EventArgs e)
        {
           Article_LoadInfo(_Autokey);
        }

        private void Article_LoadInfo(string Key)
        {

            _Article = new Article_Info(Key);
            //  txt_Autokey.Text = _Article.Key;
            txt_MaHD.Text = _Article.MaHD;
            txt_Ngayxuat.Text = _Article.Ngayxuat;
            txt_B_donvi.Text = _Article.B_donvi;
            txt_B_diachi.Text = _Article.B_diachi;
            txt_B_stk.Text = _Article.B_stk;
            txt_B_sdt.Text = _Article.B_sdt;
            txt_M_hoten.Text = _Article.M_hoten;
            txt_M_donvi.Text = _Article.M_donvi;
            txt_M_diachi.Text = _Article.M_diachi;
            txt_M_stk.Text = _Article.M_stk;
            txt_M_sdt.Text = _Article.M_sdt;
            txt_Hinhthucthanhtoan.Text = _Article.Hinhthucthanhtoan;
            txt_Tongtienhang.Text = _Article.Tongtienhang.ToString();
            txt_Thue.Text = _Article.Thue.ToString();
            txt_Tienthue.Text = _Article.Tienthue.ToString();
            txt_Tongthanhtoan.Text = _Article.Tongthanhtoan.ToString();
            txt_Manguoimua.Text = _Article.Manguoimua;
            txt_Manguoiban.Text = _Article.Manguoiban;



            lbl_Message.Text = _Article.Message;
        }
        private void Article_UpdateInfo()
        {

            _Article.MaHD = txt_MaHD.Text;
            _Article.Ngayxuat = txt_Ngayxuat.Text;
            _Article.B_donvi = txt_B_donvi.Text;
            _Article.B_diachi = txt_B_diachi.Text;
            _Article.B_stk = txt_B_stk.Text;
            _Article.B_sdt = txt_B_sdt.Text;
            _Article.M_hoten = txt_M_hoten.Text;
            _Article.M_donvi = txt_M_donvi.Text;
            _Article.M_diachi = txt_M_diachi.Text;
            _Article.M_stk = txt_M_stk.Text;
            _Article.M_sdt = txt_M_sdt.Text;
            _Article.Hinhthucthanhtoan = txt_Hinhthucthanhtoan.Text;
            _Article.Tongtienhang = float.Parse(txt_Tongtienhang.Text);
            _Article.Thue = float.Parse(txt_Thue.Text);
            _Article.Tienthue = float.Parse(txt_Tienthue.Text);
            _Article.Tongthanhtoan = float.Parse(txt_Tongthanhtoan.Text);
            _Article.Manguoimua = txt_Manguoimua.Text;
            _Article.Manguoiban = txt_Manguoiban.Text;


            _Article.Update();


            lbl_Message.Text = _Article.Message;
        }
        private bool CheckBeforeSave()
        {
            bool zResult = true;
            int zNumber;
            // if (!int.TryParse(txt_RecordStatus.Text, out zNumber))
            if (false)
            {
                zResult = false;
            }


            return zResult;
        }

        #region [ Button Action ]
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())
            {
                Article_UpdateInfo();
                //this.Close();
            }
            else
                MessageBox.Show("Vui Long kiem tra so lieu");

        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            //_Article.Key = txt_Autokey.Text;
            _Article.MaHD = txt_MaHD.Text;
            _Article.Ngayxuat = txt_Ngayxuat.Text;
            _Article.B_donvi = txt_B_donvi.Text;
            _Article.B_diachi = txt_B_diachi.Text;
            _Article.B_stk = txt_B_stk.Text;
            _Article.B_sdt = txt_B_sdt.Text;
            _Article.M_hoten = txt_M_hoten.Text;
            _Article.M_donvi = txt_M_donvi.Text;
            _Article.M_diachi = txt_M_diachi.Text;
            _Article.M_stk = txt_M_stk.Text;
            _Article.M_sdt = txt_M_sdt.Text;
            _Article.Hinhthucthanhtoan = txt_Hinhthucthanhtoan.Text;
            _Article.Tongtienhang = float.Parse(txt_Tongtienhang.Text);
            _Article.Thue = float.Parse(txt_Thue.Text);
            _Article.Tienthue = float.Parse(txt_Tienthue.Text);
            _Article.Tongthanhtoan = float.Parse(txt_Tongthanhtoan.Text);
            _Article.Manguoimua = txt_Manguoimua.Text;
            _Article.Manguoiban = txt_Manguoiban.Text;

            _Article.Create_ServerKey();
            lbl_Message.Text = _Article.Message;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {


            _Article.Delete();
            lbl_Message.Text = _Article.Message;
        }

        private void btn_Empty_Click(object sender, EventArgs e)
        {

            _Article.Empty();
            lbl_Message.Text = _Article.Message;
        }
        #endregion 

        #region [ Properties ]
        public string Autokey
        {
            set { _Autokey = value; }
        }

        #endregion


    }
}
