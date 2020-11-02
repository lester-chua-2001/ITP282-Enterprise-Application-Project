using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Lester
{
    public class DAL_PaymentDetails
    {
        private String errMsg;
        SqlConnection myconnect = DAL_Connection.GetConnection();

        //get all details from payment table
        public DataSet getAllPaymentDetails()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet paymentdetails;

            paymentdetails = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Payment");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), myconnect);
                da.Fill(paymentdetails);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                myconnect.Close();
            }

            return paymentdetails;
        }

        // company inserting into payment database
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            int result = 0;

            string query = "INSERT INTO Payment(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum) VALUES(@PaymentDate, @ChequeNo, @PaymentAmount, @Payee, @Memo, @InvoiceNum)";

            myconnect.Open();

            SqlCommand cmd = new SqlCommand(query, myconnect);
            cmd.Parameters.AddWithValue("@PaymentDate", DateTime.ParseExact(PaymentDate, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@ChequeNo", ChequeNo);
            cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
            cmd.Parameters.AddWithValue("@Payee", Payee);
            cmd.Parameters.AddWithValue("@Memo", Memo);
            cmd.Parameters.AddWithValue("@InvoiceNum", InvoiceNum);

            result += cmd.ExecuteNonQuery();

            myconnect.Close();

            return result;
        }
    }
}