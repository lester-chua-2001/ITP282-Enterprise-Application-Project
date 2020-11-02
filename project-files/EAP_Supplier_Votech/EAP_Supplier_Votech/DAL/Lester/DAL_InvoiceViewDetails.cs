using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Lester
{
    public class DAL_InvoiceViewDetails
    {
        private String errMsg;
        SqlConnection myconnect = DAL_Connection.GetConnection();

        //get all details from order item table
        public DataSet getInvoiceViewMore()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet invoiceviewmore;

            invoiceviewmore = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM OrderItem");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), myconnect);
                da.Fill(invoiceviewmore);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                myconnect.Close();
            }

            return invoiceviewmore;
        }
    }
}