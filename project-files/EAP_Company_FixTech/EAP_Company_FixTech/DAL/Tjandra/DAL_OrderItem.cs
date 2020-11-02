using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;
using System.Text;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;

namespace EAP_Company_FixTech.DAL.Tjandra
{
    public class DAL_OrderItem
    {
        private String errMsg;

        SqlConnection myConnect = DAL_Connection.GetConnection();

        // Retrieve all
        public DataTable GetAll_OrderItem()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataTable programData;

            programData = new DataTable();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM OrderItem");

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

        // Insert Inventory into Order Item table
        public int insertOrderItem(string OI_Name, string OI_Desc, string OI_Price)
        {
            int result = 0;

            //string query = "INSERT INTO OrderItem(OI_Name, OI_Desc, OI_Price) VALUES(@name, @desc, @price) SELECT ProdName, ProdDesc, ProdPrice FROM Inventory WHERE ProdId=@ProdId";
            string query = "INSERT INTO OrderItem(OI_Name, OI_Desc, OI_Price) VALUES(@OI_Name, @OI_Desc, @OI_Price)";
            myConnect.Open();
            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@OI_Name", OI_Name);
            cmd.Parameters.AddWithValue("@OI_Desc", OI_Desc);
            cmd.Parameters.AddWithValue("@OI_Price",OI_Price);


            result += cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }



        // Create order items WEB SERVICE
        public int createOrderItems(string ProdName, string ProdDesc, string ProductPrice)
        {
            Ws_Supplier_VotechClient VotechClient;
            VotechClient = new Ws_Supplier_VotechClient();
            return VotechClient.createOrderItems(ProdName, ProdDesc, ProductPrice);
        }









    }

}