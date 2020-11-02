using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace EAP_Supplier_Votech.DAL.Nelson
{
    public class DAL_Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection myCon;
            string connectionStr = ConfigurationManager.ConnectionStrings["Supplier_ConnectionString"].ConnectionString;
            myCon = new SqlConnection(connectionStr);

            return myCon;
        }
    }
}