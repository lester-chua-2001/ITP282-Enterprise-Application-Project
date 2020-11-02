using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Tjandra
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
        public int createOrderItems(string ProdName, string ProdDesc, string ProdPrice)
        {
            int result = 0;

            //string query = "INSERT INTO OrderItem(OI_Name, OI_Desc, OI_Price) VALUES(@name, @desc, @price) SELECT ProdName, ProdDesc, ProdPrice FROM Inventory WHERE ProdId=@ProdId";
            string query = "INSERT INTO OrderItem(OI_Name, OI_Desc, OI_Price) VALUES(@ProdName, @ProdDesc, @ProdPrice)";
            myConnect.Open();
            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@ProdName", ProdName);
            cmd.Parameters.AddWithValue("@ProdDesc", ProdDesc);
            cmd.Parameters.AddWithValue("@ProdPrice", ProdPrice);
            //cmd.Parameters.AddWithValue("@ProdID", ProdID);

            result += cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }






    }
}