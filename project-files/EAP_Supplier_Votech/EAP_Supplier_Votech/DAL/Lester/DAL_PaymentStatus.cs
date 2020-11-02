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
    public class DAL_PaymentStatus
    {
        SqlConnection myconnect = DAL_Connection.GetConnection();

        //Retrieve all customer order 
        public DataSet GetAllCustomerOrders()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet customerorders;

            customerorders = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT C.CO_ID, C.CO_CompanyName, C.CO_Date, C.CO_CompanyEmail,  C.CO_CompanyContact, C.CO_PaymentStatus, I.InvoiceNum, I.InvoiceDate, I.InvoiceTotalAmt, I.InvoiceStatus FROM CustomerOrder C JOIN Invoice I ON I.CO_ID = C.CO_ID");

            da = new SqlDataAdapter(sql.ToString(), myconnect);
            da.Fill(customerorders);

            myconnect.Close();

            return customerorders;
        }

        // update payment status
        public int PaymentStatusUpdate(string CO_ID, string CO_PaymentStatus)
        {

            int updatepayment = 0;
            string querstr = "UPDATE CustomerOrder SET CO_PaymentStatus= @CO_PaymentStatus WHERE CO_ID=@CO_ID";

            myconnect.Open();
            SqlCommand cmd = new SqlCommand(querstr, myconnect);
            cmd.Parameters.AddWithValue("@CO_ID", CO_ID);
            cmd.Parameters.AddWithValue("@CO_PaymentStatus", CO_PaymentStatus);

            updatepayment = cmd.ExecuteNonQuery();

            myconnect.Close();
            return updatepayment;
        }

        //search filter
        public DataTable searchcompanyname(string name)
        {
            string queryStr = "SELECT C.CO_ID, C.CO_CompanyName, C.CO_Date, C.CO_CompanyEmail,  C.CO_CompanyContact, C.CO_PaymentStatus, I.InvoiceNum, I.InvoiceDate, I.InvoiceTotalAmt, I.InvoiceStatus FROM CustomerOrder C JOIN Invoice I ON I.CO_ID = C.CO_ID WHERE C.CO_CompanyName LIKE '%' +@name+ '%'";

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