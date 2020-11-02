using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Lester
{
    public class DAL_InvoiceOrderItem
    {
        private String errMsg;

        SqlConnection myConnect = DAL_Connection.GetConnection();

        // Retrieve all
        public DataSet GetAllInvoiceOrderItem()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ds;

            ds = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM OrderItem");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), myConnect);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                myConnect.Close();
            }

            return ds;
        }

    }
}