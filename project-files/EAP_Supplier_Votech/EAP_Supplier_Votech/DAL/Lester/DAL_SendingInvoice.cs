using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using EAP_Supplier_Votech.DAL;

namespace EAP_Supplier_Votech.DAL.Lester
{
    public class DAL_SendingInvoice
    {
        SqlConnection myconnect = DAL_Connection.GetConnection();

        //Creating of Invoice
        public DataSet GetAllInvoice()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet Invoice;

            Invoice = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT C.CO_ID, C.CO_CompanyName, C.CO_Date, C.CO_CompanyEmail, C.CO_CompanyAddress, C.CO_TotalAmount, D.DO_Status FROM CustomerOrder C JOIN DeliveryOrder D on D.CO_ID = C.CO_ID");

            da = new SqlDataAdapter(sql.ToString(), myconnect);
            da.Fill(Invoice);

            myconnect.Close();

            return Invoice;
        }
        //search filter
        public DataTable searchcompanyname(string name)
        {
            string queryStr = "SELECT C.CO_ID, C.CO_CompanyName, C.CO_Date, C.CO_CompanyEmail, C.CO_CompanyAddress, C.CO_TotalAmount, D.DO_Status FROM CustomerOrder C JOIN DeliveryOrder D on D.CO_ID = C.CO_ID WHERE C.CO_CompanyName LIKE '%' +@name+ '%'";

            myconnect.Open();

            SqlCommand cmd = new SqlCommand(queryStr, myconnect);
            cmd.Parameters.AddWithValue("@name", name);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }
    }
}