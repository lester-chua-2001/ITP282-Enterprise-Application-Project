using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using EAP_Company_FixTech.DAL;

namespace EAP_Company_FixTech.DAL.Lester
{
    public class DAL_Payment
    {
        SqlConnection myconnect = DAL_Connection.GetConnection();

        //inserting into payment database
        //paying to supplier
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            int result = 0;

            string query = "INSERT INTO Payment(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum) VALUES(@PaymentDate, @ChequeNo, @PaymentAmount, @Payee, @Memo, @InvoiceNum)";

            SqlCommand cmd = new SqlCommand(query, myconnect);
            cmd.Parameters.AddWithValue("@PaymentDate", DateTime.ParseExact(PaymentDate, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@ChequeNo", ChequeNo);
            cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
            cmd.Parameters.AddWithValue("@Payee", Payee);
            cmd.Parameters.AddWithValue("@Memo", Memo);
            cmd.Parameters.AddWithValue("@InvoiceNum", InvoiceNum);

            myconnect.Open();

            cmd.ExecuteNonQuery();

            myconnect.Close();

            return result;
        }
    }
}