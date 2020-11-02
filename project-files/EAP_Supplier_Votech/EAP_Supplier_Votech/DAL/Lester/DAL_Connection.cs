using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace EAP_Supplier_Votech.DAL.Lester
{
    public class DAL_Connection 
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection dbConn;
            String connstring = ConfigurationManager.ConnectionStrings["Supplier_ConnectionString"].ConnectionString;
            dbConn = new SqlConnection(connstring);

            return dbConn;
        }
    }
}