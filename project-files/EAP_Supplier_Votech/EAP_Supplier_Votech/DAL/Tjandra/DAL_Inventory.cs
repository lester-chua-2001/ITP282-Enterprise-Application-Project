using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace EAP_Supplier_Votech.DAL.Tjandra
{
    public class DAL_Inventory
    {
        private String errMsg;

        SqlConnection myConnect = DAL_Connection.GetConnection();


        // Retrieve all
        public DataSet GetAll_Inventory()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet programData;

            programData = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT ProdId, ProdName, ProdDesc, ProdPrice FROM Inventory");

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














    }
}