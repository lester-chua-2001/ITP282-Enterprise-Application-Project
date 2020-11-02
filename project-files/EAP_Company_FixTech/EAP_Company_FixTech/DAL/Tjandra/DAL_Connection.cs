using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EAP_Company_FixTech.DAL.Tjandra
{
    public class DAL_Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection myCon;
            string connectionStr = ConfigurationManager.ConnectionStrings["Company_ConnectionString"].ConnectionString;
            myCon = new SqlConnection(connectionStr);

            return myCon;
        }
    }
}