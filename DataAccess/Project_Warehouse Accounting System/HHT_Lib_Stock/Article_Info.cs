using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HHT.Connection;

namespace HHT_Lib.Stock
{
    public class Article_Info
    {

        #region [ Field Name ]
        private string _Autokey = "";
        private string _MaHD = "";
        private string _Ngayxuat = "";
        private string _B_donvi = "";
        private string _B_diachi = "";
        private string _B_stk = "";
        private string _B_sdt = "";
        private string _M_hoten = "";
        private string _M_donvi = "";
        private string _M_diachi = "";
        private string _M_stk = "";
        private string _M_sdt = "";
        private string _Hinhthucthanhtoan = "";
        private float _Tongtienhang = 0;
        private float _Thue = 0;
        private float _Tienthue = 0;
        private float _Tongthanhtoan = 0;
        private string _Manguoimua = "";
        private string _Manguoiban = "";      
        private int _RecordStatus = 0;
        private DateTime? _CreatedOn = null;
        private string _CreatedBy = "";
        private string _CreatedName = "";
        private DateTime? _ModifiedOn = null;
        private string _ModifiedBy = "";
        private string _ModifiedName = "";
        private string _Message = "";
        #endregion

        #region [ Constructor Get Information ]
        public Article_Info()
        {
            Guid zNewID = Guid.NewGuid(); 
            _Autokey = zNewID.ToString();
        }
        public Article_Info(string Autokey)
        {
            string zSQL = "SELECT * FROM [dbo].[HoaDon1] WHERE Autokey = @Autokey AND RecordStatus != 99 ";
            string zConnectionString = ConnectDataBase.ConnectionString;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.CommandType = CommandType.Text;
                zCommand.Parameters.Add("@Autokey", SqlDbType.UniqueIdentifier).Value = new Guid(Autokey);
                SqlDataReader zReader = zCommand.ExecuteReader();
                if (zReader.HasRows)
                {
                    zReader.Read();
                    _Autokey = zReader["Autokey"].ToString();
                    _MaHD = zReader["MaHD"].ToString();
                    _Ngayxuat = zReader["Ngayxuat"].ToString();
                    _B_donvi = zReader["B_donvi"].ToString();
                    _B_diachi = zReader["B_diachi"].ToString();
                    _B_stk = zReader["B_stk"].ToString();
                    _B_sdt = zReader["B_sdt"].ToString();
                    _M_hoten = zReader["M_hoten"].ToString();
                    _M_donvi = zReader["M_donvi"].ToString();
                    _M_diachi = zReader["M_diachi"].ToString();
                    _M_stk = zReader["M_stk"].ToString();
                    _M_sdt = zReader["M_sdt"].ToString();
                    _Hinhthucthanhtoan = zReader["Hinhthucthanhtoan"].ToString();
                    _Tongtienhang = float.Parse(zReader["Tongtienhang"].ToString());
                    _Thue = float.Parse(zReader["Thue"].ToString());
                    _Tienthue = float.Parse(zReader["Tienthue"].ToString());
                    _Tongthanhtoan = float.Parse(zReader["Tongthanhtoan"].ToString());
                    _Manguoimua = zReader["Manguoimua"].ToString();
                    _Manguoiban = zReader["Manguoiban"].ToString();
                    _RecordStatus = int.Parse(zReader["RecordStatus"].ToString());
                    if (zReader["CreatedOn"] != DBNull.Value)
                        _CreatedOn = (DateTime)zReader["CreatedOn"];
                    _CreatedBy = zReader["CreatedBy"].ToString();
                    _CreatedName = zReader["CreatedName"].ToString();
                    if (zReader["ModifiedOn"] != DBNull.Value)
                        _ModifiedOn = (DateTime)zReader["ModifiedOn"];
                    _ModifiedBy = zReader["ModifiedBy"].ToString();
                    _ModifiedName = zReader["ModifiedName"].ToString();
                    _Message = "200 OK";
                }
                else
                {
                    _Message = "404 Not Found";
                }
                zReader.Close();
                zCommand.Dispose();
            }
            catch (Exception Err)
            {
                _Message = "501 " + Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
        }
      
        #endregion

        #region [ Properties ]
        public string Key
        {
            get { return _Autokey; }
            set { _Autokey = value; }
        }
        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        public string Ngayxuat
        {
            get { return _Ngayxuat; }
            set { _Ngayxuat = value; }
        }
        public string B_donvi
        {
            get { return _B_donvi; }
            set { _B_donvi = value; }
        }
        public string B_diachi
        {
            get { return _B_diachi; }
            set { _B_diachi = value; }
        }
        public string B_stk
        {
            get { return _B_stk; }
            set { _B_stk = value; }
        }
        public string B_sdt
        {
            get { return _B_sdt; }
            set { _B_sdt = value; }
        }
        public string M_hoten
        {
            get { return _M_hoten; }
            set { _M_hoten = value; }
        }
        public string M_donvi
        {
            get { return _M_donvi; }
            set { _M_donvi = value; }
        }
        public string M_diachi
        {
            get { return _M_diachi; }
            set { _M_diachi = value; }
        }
        public string M_stk
        {
            get { return _M_stk; }
            set { _M_stk = value; }
        }
        public string M_sdt
        {
            get { return _M_sdt; }
            set { _M_sdt = value; }
        }
        public string Hinhthucthanhtoan
        {
            get { return _Hinhthucthanhtoan; }
            set { _Hinhthucthanhtoan = value; }
        }
        public float Tongtienhang
        {
            get { return _Tongtienhang; }
            set { _Tongtienhang = value; }
        }
        public float Thue
        {
            get { return _Thue; }
            set { _Thue = value; }
        }
        public float Tienthue
        {
            get { return _Tienthue; }
            set { _Tienthue = value; }
        }
        public float Tongthanhtoan
        {
            get { return _Tongthanhtoan; }
            set { _Tongthanhtoan = value; }
        }
        public string Manguoimua
        {
            get { return _Manguoimua; }
            set { _Manguoimua  = value; }
        }
        public string Manguoiban
        {
            get { return _Manguoiban; }
            set { _Manguoiban = value; }
        }
      
        public int RecordStatus
        {
            get { return _RecordStatus; }
            set { _RecordStatus = value; }
        }
        public DateTime? CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public string CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public string CreatedName
        {
            get { return _CreatedName; }
            set { _CreatedName = value; }
        }
        public DateTime? ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public string ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }
        public string ModifiedName
        {
            get { return _ModifiedName; }
            set { _ModifiedName = value; }
        }
        public string Code
        {
            get
            {
                if (_Message.Length >= 3)
                    return _Message.Substring(0, 3);
                else return "";
            }
        }
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        #endregion

        #region [ Constructor Update Information ]
        public string Create_ServerKey()
        {
            //---------- String SQL Access Database ---------------

            string zSQL = "INSERT INTO [dbo].[HoaDon1]  ("
        + " MaHD,Ngayxuat,B_donvi,B_diachi,B_stk,B_sdt,M_hoten,M_donvi,M_diachi,M_stk,M_sdt,Hinhthucthanhtoan,Tongtienhang,Thue,Tienthue,Tongthanhtoan,Manguoimua,Manguoiban,RecordStatus ,CreatedBy ,CreatedName ,ModifiedBy ,ModifiedName ) "
         + " VALUES ( "
         + " @MaHD,@Ngayxuat,@B_donvi,@B_diachi,@B_stk,@B_sdt,@M_hoten,@M_donvi,@M_diachi,@M_stk,@M_sdt,@Hinhthucthanhtoan,@Tongtienhang,@Thue,@Tienthue,@Tongthanhtoan,@Manguoimua,@Manguoiban,@RecordStatus ,@CreatedBy ,@CreatedName ,@ModifiedBy ,@ModifiedName ) ";
            string zResult = "";
            string zConnectionString = ConnectDataBase.ConnectionString;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.CommandType = CommandType.Text;
                zCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = _MaHD;
                zCommand.Parameters.Add("@Ngayxuat", SqlDbType.NVarChar).Value = _Ngayxuat;
                zCommand.Parameters.Add("@B_donvi", SqlDbType.NVarChar).Value = _B_donvi;
                zCommand.Parameters.Add("@B_diachi", SqlDbType.NVarChar).Value = _B_diachi;
                zCommand.Parameters.Add("@B_stk", SqlDbType.NVarChar).Value = _B_stk;
                zCommand.Parameters.Add("@B_sdt", SqlDbType.NVarChar).Value = _B_sdt;
                zCommand.Parameters.Add("@M_hoten", SqlDbType.NVarChar).Value = _M_hoten;
                zCommand.Parameters.Add("@M_donvi", SqlDbType.NVarChar).Value = _M_donvi;
                zCommand.Parameters.Add("@M_diachi", SqlDbType.NVarChar).Value = _M_diachi;
                zCommand.Parameters.Add("@M_stk", SqlDbType.NVarChar).Value = _M_stk;
                zCommand.Parameters.Add("@M_sdt", SqlDbType.NVarChar).Value = _M_sdt;
                zCommand.Parameters.Add("@Hinhthucthanhtoan", SqlDbType.NVarChar).Value = _Hinhthucthanhtoan;
                zCommand.Parameters.Add("@Tongtienhang", SqlDbType.Float).Value = _Tongtienhang;
                zCommand.Parameters.Add("@Thue", SqlDbType.Float).Value = _Thue;
                zCommand.Parameters.Add("@Tienthue", SqlDbType.Float).Value = _Tienthue;
                zCommand.Parameters.Add("@Tongthanhtoan", SqlDbType.Float).Value = _Tongthanhtoan;
                zCommand.Parameters.Add("@Manguoimua", SqlDbType.NVarChar).Value = _Manguoimua;
                zCommand.Parameters.Add("@Manguoiban", SqlDbType.NVarChar).Value = _Manguoiban;               
                zCommand.Parameters.Add("@RecordStatus", SqlDbType.Int).Value = _RecordStatus;
                zCommand.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = _CreatedBy;
                zCommand.Parameters.Add("@CreatedName", SqlDbType.NVarChar).Value = _CreatedName;
                zCommand.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar).Value = _ModifiedBy;
                zCommand.Parameters.Add("@ModifiedName", SqlDbType.NVarChar).Value = _ModifiedName;
                zResult = zCommand.ExecuteNonQuery().ToString();
                zCommand.Dispose();
                _Message = "201 Created";
            }
            catch (Exception Err)
            {
                _Message = "501 " + Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
            return zResult;
        }
        public string Create_ClientKey()
        {
            //---------- String SQL Access Database ---------------
            string zSQL = "INSERT INTO [dbo].[HoaDon1] ("
        + "Autokey,MaHD,Ngayxuat,B_donvi,B_diachi,B_stk,B_sdt,M_hoten,M_donvi,M_diachi,M_stk,M_sdt,Hinhthucthanhtoan,Tongtienhang,Thue,Tienthue,Tongthanhtoan,Manguoimua,Manguoiban,RecordStatus ,CreatedBy ,CreatedName ,ModifiedBy ,ModifiedName ) "
         + " VALUES ( "
         + "@Autokey,@MaHD,@Ngayxuat,@B_donvi,@B_diachi,@B_stk,@B_sdt,@M_hoten,@M_donvi,@M_diachi,@M_stk,@M_sdt,@Hinhthucthanhtoan,@Tongtienhang,@Thue,@Tienthue,@Tongthanhtoan,@Manguoimua,@Manguoiban,@RecordStatus ,@CreatedBy ,@CreatedName ,@ModifiedBy ,@ModifiedName) ";
            string zResult = "";
            string zConnectionString = ConnectDataBase.ConnectionString;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.CommandType = CommandType.Text;
                zCommand.Parameters.Add("@Autokey", SqlDbType.UniqueIdentifier).Value = new Guid(_Autokey);
                zCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = _MaHD;
                zCommand.Parameters.Add("@Ngayxuat", SqlDbType.NVarChar).Value = _Ngayxuat;
                zCommand.Parameters.Add("@B_donvi", SqlDbType.NVarChar).Value = _B_donvi;
                zCommand.Parameters.Add("@B_diachi", SqlDbType.NVarChar).Value = _B_diachi;
                zCommand.Parameters.Add("@B_stk", SqlDbType.NVarChar).Value = _B_stk;
                zCommand.Parameters.Add("@B_sdt", SqlDbType.NVarChar).Value = _B_sdt;
                zCommand.Parameters.Add("@M_hoten", SqlDbType.NVarChar).Value = _M_hoten;
                zCommand.Parameters.Add("@M_donvi", SqlDbType.NVarChar).Value = _M_donvi;
                zCommand.Parameters.Add("@M_diachi", SqlDbType.NVarChar).Value = _M_diachi;
                zCommand.Parameters.Add("@M_stk", SqlDbType.NVarChar).Value = _M_stk;
                zCommand.Parameters.Add("@M_sdt", SqlDbType.NVarChar).Value = _M_sdt;
                zCommand.Parameters.Add("@Hinhthucthanhtoan", SqlDbType.NVarChar).Value = _Hinhthucthanhtoan;
                zCommand.Parameters.Add("@Tongtienhang", SqlDbType.Float).Value = _Tongtienhang;
                zCommand.Parameters.Add("@Thue", SqlDbType.Float).Value = _Thue;
                zCommand.Parameters.Add("@Tienthue", SqlDbType.Float).Value = _Tienthue;
                zCommand.Parameters.Add("@Tongthanhtoan", SqlDbType.Float).Value = _Tongthanhtoan;
                zCommand.Parameters.Add("@Manguoimua", SqlDbType.NVarChar).Value = _Manguoimua;
                zCommand.Parameters.Add("@Manguoiban", SqlDbType.NVarChar).Value = _Manguoiban;
                zCommand.Parameters.Add("@RecordStatus", SqlDbType.Int).Value = _RecordStatus;
                zCommand.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = _CreatedBy;
                zCommand.Parameters.Add("@CreatedName", SqlDbType.NVarChar).Value = _CreatedName;
                zCommand.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar).Value = _ModifiedBy;
                zCommand.Parameters.Add("@ModifiedName", SqlDbType.NVarChar).Value = _ModifiedName;
                zResult = zCommand.ExecuteNonQuery().ToString();
                zCommand.Dispose();
                _Message = "201 Created";
            }
            catch (Exception Err)
            {
                _Message = "501 " + Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
            return zResult;
        }
        public string Update()
        {
            string zSQL = "UPDATE [dbo].[HoaDon1] SET "
                        + " MaHD = @MaHD,"
                        + " Ngayxuat= @Ngayxuat,"
                        + " B_donvi = @B_donvi,"
                        + " B_diachi = @B_diachi,"
                        + " B_stk = @B_stk,"
                        + " B_sdt = @B_sdt,"
                        + " M_hoten = @M_hoten,"
                        + " M_donvi = @M_donvi,"
                        + " M_diachi = @M_diachi,"
                        + " M_stk = @M_stk,"
                        + " M_sdt = @M_sdt,"
                        + " Hinhthucthanhtoan = @Hinhthucthanhtoan,"
                        + " Tongtienhang = @Tongtienhang,"
                        + " Thue = @Thue,"
                        + " Tienthue = @Tienthue,"
                        + " Tongthanhtoan = @Tongthanhtoan,"
                        + " Manguoimua = @Manguoimua,"
                        + " Manguoiban = @Manguoiban,"
                        + " RecordStatus = @RecordStatus,"
                        + " ModifiedOn = GetDate(),"
                        + " ModifiedBy = @ModifiedBy,"
                        + " ModifiedName = @ModifiedName"
                       + " WHERE Autokey = @Autokey";
            string zResult = "";
            string zConnectionString = ConnectDataBase.ConnectionString;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.CommandType = CommandType.Text;
                zCommand.Parameters.Add("@Autokey", SqlDbType.NVarChar).Value = _Autokey;
                zCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = _MaHD;
                zCommand.Parameters.Add("@Ngayxuat", SqlDbType.NVarChar).Value = _Ngayxuat;
                zCommand.Parameters.Add("@B_donvi", SqlDbType.NVarChar).Value = _B_donvi;
                zCommand.Parameters.Add("@B_diachi", SqlDbType.NVarChar).Value = _B_diachi;
                zCommand.Parameters.Add("@B_stk", SqlDbType.NVarChar).Value = _B_stk;
                zCommand.Parameters.Add("@B_sdt", SqlDbType.NVarChar).Value = _B_sdt;
                zCommand.Parameters.Add("@M_hoten", SqlDbType.NVarChar).Value = _M_hoten;
                zCommand.Parameters.Add("@M_donvi", SqlDbType.NVarChar).Value = _M_donvi;
                zCommand.Parameters.Add("@M_diachi", SqlDbType.NVarChar).Value = _M_diachi;
                zCommand.Parameters.Add("@M_stk", SqlDbType.NVarChar).Value = _M_stk;
                zCommand.Parameters.Add("@M_sdt", SqlDbType.NVarChar).Value = _M_sdt;
                zCommand.Parameters.Add("@Hinhthucthanhtoan", SqlDbType.NVarChar).Value = _Hinhthucthanhtoan;
                zCommand.Parameters.Add("@Tongtienhang", SqlDbType.Float).Value = _Tongtienhang;
                zCommand.Parameters.Add("@Thue", SqlDbType.Float).Value = _Thue;
                zCommand.Parameters.Add("@Tienthue", SqlDbType.Float).Value = _Tienthue;
                zCommand.Parameters.Add("@Tongthanhtoan", SqlDbType.Float).Value = _Tongthanhtoan;
                zCommand.Parameters.Add("@Manguoimua", SqlDbType.NVarChar).Value = _Manguoimua;
                zCommand.Parameters.Add("@Manguoiban", SqlDbType.NVarChar).Value = _Manguoiban;
                zCommand.Parameters.Add("@RecordStatus", SqlDbType.Int).Value = _RecordStatus;
                zCommand.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = _CreatedBy;
                zCommand.Parameters.Add("@CreatedName", SqlDbType.NVarChar).Value = _CreatedName;
                zCommand.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar).Value = _ModifiedBy;
                zCommand.Parameters.Add("@ModifiedName", SqlDbType.NVarChar).Value = _ModifiedName;
                zResult = zCommand.ExecuteNonQuery().ToString();
                zCommand.Dispose();
                _Message = "200 OK";
            }
            catch (Exception Err)
            {
                _Message = "501 " + Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
            return zResult;
        }
        public string Delete()
        {
            string zResult = "";
            //---------- String SQL Access Database ---------------
            string zSQL = "UPDATE [dbo].[HoaDon1] Set RecordStatus = 99 WHERE Autokey = @Autokey";
            string zConnectionString = ConnectDataBase.ConnectionString;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.Parameters.Add("@Autokey", SqlDbType.UniqueIdentifier).Value = new Guid(_Autokey);
                zResult = zCommand.ExecuteNonQuery().ToString();
                zCommand.Dispose();
            }
            catch (Exception Err)
            {
                _Message = Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
            return zResult;
        }
        public string Empty()
        {
            string zResult = "";
            //---------- String SQL Access Database ---------------
            string zSQL = "DELETE FROM [dbo].[HoaDon1] WHERE Autokey = @Autokey";
            string zConnectionString = ConnectDataBase.ConnectionString;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.Parameters.Add("@Autokey", SqlDbType.UniqueIdentifier).Value = new Guid(_Autokey);
                zResult = zCommand.ExecuteNonQuery().ToString();
                zCommand.Dispose();
            }
            catch (Exception Err)
            {
                _Message = Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
            return zResult;
        }
        #endregion

    }
}
