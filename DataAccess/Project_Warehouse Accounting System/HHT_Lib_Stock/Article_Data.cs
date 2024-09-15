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
    public class Article_Data
    {
        public static DataTable List(string OrderBy, int PageNumber, int PageSize)
        {
            DataTable zTable = new DataTable();
            string zSQL =" SELECT  A.* FROM[dbo].[HoaDon1] A WHERE RecordStatus != 99";
            // " LEFT JOIN SPT_ArticleCategory B ON A.CategoryKey = B.CategoryKey " +
            //  ;
            //if (OrderBy.Trim().Length > 0)
            //    zSQL += "CreatedOn" + OrderBy;
            //zSQL += " OFFSET @PageSize * (@PageNumber - 1) ROWS " +
            //      " FETCH NEXT @PageSize ROWS ONLY OPTION(RECOMPILE)";
            if (OrderBy.Trim().Length > 0)
                zSQL +="Order By" + "   CreatedOn";
            zSQL += " OFFSET @PageSize * (@PageNumber - 1) ROWS " +
                  " FETCH NEXT @PageSize ROWS ONLY OPTION(RECOMPILE)";
            string zConnectionString = ConnectDataBase.ConnectionString;
            try
            {
                SqlConnection zConnect = new SqlConnection(zConnectionString);
                zConnect.Open();
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                zCommand.Parameters.Add("@PageNumber", SqlDbType.Int).Value = PageNumber;
                SqlDataAdapter zAdapter = new SqlDataAdapter(zCommand);
                zAdapter.Fill(zTable);
                zCommand.Dispose();
                zConnect.Close();
            }
            catch (Exception ex)
            {
                string zstrMessage = ex.ToString();
            }
            return zTable;
        }
        public static DataTable List(string OrderBy)
        {
            DataTable zTable = new DataTable();
            string zSQL = " SELECT  A.* FROM[dbo].[HoaDon1] A WHERE RecordStatus != 99";
            
     
                zSQL += "Order By" + OrderBy;
          
            string zConnectionString = ConnectDataBase.ConnectionString;
            try
            {
                SqlConnection zConnect = new SqlConnection(zConnectionString);
                zConnect.Open();
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                SqlDataAdapter zAdapter = new SqlDataAdapter(zCommand);
                zAdapter.Fill(zTable);
                zCommand.Dispose();
                zConnect.Close();
            }
            catch (Exception ex)
            {
                string zstrMessage = ex.ToString();
            }
            return zTable;
        }
        public static int Total_Record()
        {
            int zQuantity = 0;
            string zSQL = "SELECT  Count(*) FROM [dbo].[HoaDon1] WHERE RecordStatus != 99 ";
            string zConnectionString = ConnectDataBase.ConnectionString;
            try
            {
                SqlConnection zConnect = new SqlConnection(zConnectionString);
                zConnect.Open();
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                string zResult = zCommand.ExecuteScalar().ToString();
                int.TryParse(zResult, out zQuantity);
                zCommand.Dispose();
                zConnect.Close();
            }
            catch (Exception ex)
            {
                string zstrMessage = ex.ToString();
            }
            return zQuantity;
        }
        public static DataTable List_Search(string Content, string OrderBy, int PageNumber, int PageSize)
        {
            DataTable zTable = new DataTable();
            string zSQL = "SELECT  * FROM [HoaDon1] WHERE RecordStatus != 99 ";
            if (Content.Length > 1)
            {
                zSQL += "AND (ArticleName LIKE @Content OR ImageSmall LIKE @Content)";
            }
            else
            {
                zSQL += " AND Name LIKE @Content ";
            }
            if (OrderBy.Trim().Length > 0)
                zSQL += " ORDER BY " + OrderBy;
            zSQL += " OFFSET @PageSize * (@PageNumber - 1) ROWS " +
                  " FETCH NEXT @PageSize ROWS ONLY OPTION(RECOMPILE)";
            string zConnectionString = ConnectDataBase.ConnectionString;
            try
            {
                SqlConnection zConnect = new SqlConnection(zConnectionString);
                zConnect.Open();
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                if (Content.Length > 1)
                    zCommand.Parameters.Add("@Content", SqlDbType.NVarChar).Value = "%" + Content + "%";
                else
                    zCommand.Parameters.Add("@Content", SqlDbType.NVarChar).Value = Content + "%";
                zCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = PageSize;
                zCommand.Parameters.Add("@PageNumber", SqlDbType.Int).Value = PageNumber;
                SqlDataAdapter zAdapter = new SqlDataAdapter(zCommand);
                zAdapter.Fill(zTable);
                zCommand.Dispose();
                zConnect.Close();
            }
            catch (Exception ex)
            {
                string zstrMessage = ex.ToString();
            }
            return zTable;
        }
       



    }
}
