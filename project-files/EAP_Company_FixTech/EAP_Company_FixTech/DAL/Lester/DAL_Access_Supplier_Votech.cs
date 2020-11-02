using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;


namespace EAP_Company_FixTech.DAL.Lester
{
    public class DAL_Access_Supplier_Votech
    {
        SqlConnection myConnect = DAL_Connection.GetConnection();
        public DataSet GetAllCustomerOrders()
        {
            Ws_Supplier_VotechClient supplier_votech;
            supplier_votech = new Ws_Supplier_VotechClient();
            return supplier_votech.GetAllCustomerOrders();
        }

        //insert into local database
        public int companyPaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            int result = 0;

            string query = "INSERT INTO Payment(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum) VALUES(@PaymentDate, @ChequeNo, @PaymentAmount, @Payee, @Memo, @InvoiceNum)";

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@PaymentDate", DateTime.ParseExact(PaymentDate, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@ChequeNo", ChequeNo);
            cmd.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
            cmd.Parameters.AddWithValue("@Payee", Payee);
            cmd.Parameters.AddWithValue("@Memo", Memo);
            cmd.Parameters.AddWithValue("@InvoiceNum", InvoiceNum);

            myConnect.Open();

            cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }
        // insert into supplier
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            Ws_Supplier_VotechClient VotechClient;
            VotechClient = new Ws_Supplier_VotechClient();
            return VotechClient.PaySupplier(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }

        //view created invoice
        public DAL_CreateInvoice[] GetInvoiceCreated()
        {
            Ws_Supplier_VotechClient VotechClient;
            VotechClient = new Ws_Supplier_VotechClient();
            return VotechClient.GetInvoiceCreated();
        }
        public DataSet getInvoiceOrderItem()
        {
            Ws_Supplier_VotechClient VotechClient;
            VotechClient = new Ws_Supplier_VotechClient();
            return VotechClient.getallInvoiceOrderItem();
        }

        //public int PaymentStatusUpdate(string CO_ID, string CO_PaymentStatus)
        //{
        //    Ws_Supplier_VotechClient Company_Fixtech;
        //    Company_Fixtech = new Ws_Supplier_VotechClient();
        //    return Company_Fixtech.PaymentStatusUpdate(CO_ID, CO_PaymentStatus);
        //}

    }
}