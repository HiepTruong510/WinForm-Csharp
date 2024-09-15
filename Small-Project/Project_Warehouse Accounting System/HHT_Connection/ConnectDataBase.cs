using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHT.Connection
{
    public class ConnectDataBase
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source=LAPTOP\SQLEXPRESS01;Initial Catalog=1;Integrated Security=True"; 
            }
        }
    }
}
