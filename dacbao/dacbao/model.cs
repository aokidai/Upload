using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dacbao
{
    class model
    {
        public static string cnnStr = "Data Source=DESKTOP-80KUQ2B\\SQLEXPRESS01;Initial Catalog=QLDATBAO;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
    }
}
