using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;
using System.Data.SqlClient;
using EAP_Company_FixTech.DAL.Tjandra;
using System.Text;

namespace EAP_Company_FixTech.DAL.Tjandra
{
    public class DAL_PurchaseOrder
    {
        private String errMsg;

        SqlConnection myConnect = DAL_Connection.GetConnection();

        // WEB SERVICE
        public int insertPurchaseOrder(string name, string email, string contact, string address, string date)
        {
            Ws_Supplier_VotechClient VotechClient;
            VotechClient = new Ws_Supplier_VotechClient();
            return VotechClient.insertPurchaseOrder(name, email, contact, address, date);
        }

        // Purchase Order
        public int insertOrderItems(string date)
        {
            int result = 0;

            //string query = "INSERT INTO CustomerOrder(CO_Name) VALUES(@name)";
            string query = "INSERT INTO PurchaseOrder(PO_Date) VALUES(@date)";
            myConnect.Open();
            SqlCommand cmd = new SqlCommand(query, myConnect);  
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(date));

            result += cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // Retrieve purchase orders
        public DataTable GetAll_PurchaseOrders()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataTable programData;

            programData = new DataTable();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM PurchaseOrder");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), myConnect);
                da.Fill(programData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                myConnect.Close();
            }

            return programData;
        }

        // // Update
        public int updatePurchaseOrder(int PO_ID, string Note)
        {
            int result = 0;

            string query = "UPDATE PurchaseOrder SET PO_AdminComment=@PO_AdminComment WHERE PO_ID=@PO_ID";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);

            cmd.Parameters.AddWithValue("@PO_ID", PO_ID);
            cmd.Parameters.AddWithValue("@PO_AdminComment", Note);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

         // Delete REJECT 
        public int deletePurchaseOrder(int PO_ID)
        {
            int result = 0;

            string query = "DELETE PurchaseOrder WHERE PO_ID=@PO_ID";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@PO_ID", PO_ID);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }








    }
}