using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Tjandra
{
    public class DAL_CustomerOrder
    {
        private String errMsg;

        SqlConnection myConnect = DAL_Connection.GetConnection();

        private string _CO_ID, _CO_CompanyName, _CO_CompanyEmail, _CO_CompanyContact, _CO_CompanyAddress, _CO_Date, _CO_AdminComment, _CO_Archive, _ProdID, _OI_ID, _PO_ID;

        public DAL_CustomerOrder()
        {
            this._CO_ID = null;
            this._CO_CompanyName = null;
            this._CO_CompanyEmail = null;
            this._CO_CompanyContact = null;
            this._CO_CompanyAddress = null;
            this._CO_Date = null;
            this._CO_AdminComment = null;
            this._CO_Archive = null;
            this._ProdID = null;
            this._OI_ID = null;
            this._PO_ID = null;
        }

        public DAL_CustomerOrder(string aCO_ID, string aCO_CompanyName, string aCO_CompanyEmail, string aCO_CompanyContact, string aCO_CompanyAddress, string aCO_Date, string aCO_AdminComment,string aCO_Archive, string aProdID, string aOI_ID, string aPO_ID)
        {
            this._CO_ID = aCO_ID;
            this._CO_CompanyName = aCO_CompanyName;
            this._CO_CompanyEmail = aCO_CompanyEmail;
            this._CO_CompanyContact = aCO_CompanyContact;
            this._CO_CompanyAddress = aCO_CompanyAddress;
            this._CO_Date = aCO_Date;
            this._CO_AdminComment = aCO_AdminComment;
            this._CO_Archive = aCO_Archive;
            this._ProdID = aProdID;
            this._OI_ID = aOI_ID;
            this._PO_ID = aPO_ID;
        }

        public string CO_ID
        {
            get { return _CO_ID; }
            set { _CO_ID = value; }
        }

        public string CO_CompanyName
        {
            get { return _CO_CompanyName; }
            set { _CO_CompanyName = value; }
        }

        public string CO_CompanyEmail
        {
            get { return _CO_CompanyEmail; }
            set { _CO_CompanyEmail = value; }
        }

        public string CO_CompanyContact
        {
            get { return _CO_CompanyContact; }
            set { _CO_CompanyContact = value; }
        }

        public string CO_CompanyAddress
        {
            get { return _CO_CompanyAddress; }
            set { _CO_CompanyAddress = value; }
        }

        public string CO_Date
        {
            get { return _CO_Date; }
            set { _CO_Date = value; }
        }

        public string CO_AdminComment
        {
            get { return _CO_AdminComment; }
            set { _CO_AdminComment = value; }
        }

        public string CO_Archive
        {
            get { return _CO_Archive; }
            set { _CO_Archive = value; }
        }

        public string ProdID
        {
            get { return _ProdID; }
            set { _ProdID = value; }
        }

        public string OI_ID
        {
            get { return _OI_ID; }
            set { _OI_ID = value; }
        }

        public string PO_ID
        {
            get { return _PO_ID; }
            set { _PO_ID = value; }
        }

        // Retrieve row by ID
        public List<DAL_CustomerOrder> GetSingleCustomerOrder(string ID)
        {
            List<DAL_CustomerOrder> CO_List = new List<DAL_CustomerOrder>();

            string queryStr = "SELECT * FROM CustomerOrder WHERE CO_ID = @CO_ID";

            myConnect.Open();
            SqlCommand cmd = new SqlCommand(queryStr, myConnect);

            cmd.Parameters.AddWithValue("@CO_ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string CO_ID = dr["CO_ID"].ToString();
                string CO_CompanyName = dr["CO_CompanyName"].ToString();
                string CO_CompanyEmail = dr["CO_CompanyEmail"].ToString();
                string CO_CompanyContact = dr["CO_CompanyContact"].ToString();
                string CO_CompanyAddress = dr["CO_CompanyAddress"].ToString();
                string CO_Date = dr["CO_Date"].ToString();
                string CO_AdminComment = dr["CO_AdminComment"].ToString();
                string CO_Archive = dr["CO_Archive"].ToString();
                string ProdID = dr["ProdID"].ToString();
                string OI_ID = dr["OI_ID"].ToString();
                string PO_ID = dr["PO_ID"].ToString();


                DAL_CustomerOrder obj = new DAL_CustomerOrder(CO_ID, CO_CompanyName, CO_CompanyEmail, CO_CompanyContact, CO_CompanyAddress, CO_Date, CO_AdminComment, CO_Archive, ProdID, OI_ID, PO_ID);

                CO_List.Add(obj);
            }

            myConnect.Close();
            return CO_List;
        }

        // Retrieve all
        public DataSet GetAll_CustomerOrders()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet programData;

            programData = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM CustomerOrder WHERE CO_Archive=0");

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

        public DataSet GetCompleted_CustomerOrders()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet programData;

            programData = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM CustomerOrder WHERE CO_DeliveryStatus='Delivered' AND CO_PaymentStatus='Paid'");

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


        public DataSet GetAll_CustomerOrdersArchived()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet programData;

            programData = new DataSet();

            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM CustomerOrder WHERE CO_Archive=1");

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


        // Update
        public int updatePurchaseOrder(int CO_ID, string Note)
        {
            int result = 0;

            string query = "UPDATE CustomerOrder SET CO_AdminComment=@CO_AdminComment WHERE CO_ID=@CO_ID";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);

            cmd.Parameters.AddWithValue("@CO_ID", CO_ID);
            cmd.Parameters.AddWithValue("@CO_AdminComment", Note);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // Archive
        public int deletePurchaseOrder(int CO_ID)
        {
            int result = 0;

            //string query = "DELETE CustomerOrder WHERE CO_ID=@CO_ID";

            string query = "UPDATE CustomerOrder SET CO_Archive=1 WHERE CO_ID=@CO_ID ";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@CO_ID", CO_ID);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // Restore
        public int restoreCustomerOrder(int CO_ID)
        {
            int result = 0;

            //string query = "DELETE CustomerOrder WHERE CO_ID=@CO_ID";

            string query = "UPDATE CustomerOrder SET CO_Archive=0 WHERE CO_ID=@CO_ID ";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@CO_ID", CO_ID);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // Search Filter
        public DataTable SearchPurchaseOrder(string name)
        {
            string queryStr = "SELECT * FROM CustomerOrder WHERE CO_CompanyName LIKE '%' +@name+ '%' AND CO_Archive=0 ";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(queryStr, myConnect);
            cmd.Parameters.AddWithValue("@name", name);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }

        // Search completed orders
        public DataTable SearchCompletedOrders(string name)
        {
            string queryStr = "SELECT * FROM CustomerOrder WHERE CO_CompanyName LIKE '%' +@name+ '%' AND CO_Archive=0 AND CO_DeliveryStatus='Delivered' AND CO_PaymentStatus='Paid'";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(queryStr, myConnect);
            cmd.Parameters.AddWithValue("@name", name);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }

        // Drop down list Filter
        public DataTable filterCustomerOrder_DDL(string status)
        {
            string queryStr;

            if (status == "Delivery Status")
            {
                queryStr = "SELECT * FROM CustomerOrder";
            }
            else
            {
                queryStr = "SELECT * FROM CustomerOrder WHERE CO_DeliveryStatus = '" + status +"'";
            }

            SqlCommand cmd = new SqlCommand(queryStr, myConnect);
            myConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            myConnect.Close();

            return dt;
        }

        public DataTable filterCO_PaymentStatus(string status)
        {
            string queryStr;

            if (status == "Payment Status")
            {
                queryStr = "SELECT * FROM CustomerOrder";
            }
            else
            {
                queryStr = "SELECT * FROM CustomerOrder WHERE CO_PaymentStatus = '" + status + "'";
            }

            SqlCommand cmd = new SqlCommand(queryStr, myConnect);
            myConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            myConnect.Close();

            return dt;
        }






    }
}