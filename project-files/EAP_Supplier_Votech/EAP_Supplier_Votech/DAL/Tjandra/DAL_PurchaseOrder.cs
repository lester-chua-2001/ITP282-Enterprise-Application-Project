using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Text;

using EAP_Supplier_Votech.DAL.Tjandra;

namespace EAP_Supplier_Votech.DAL.Tjandra
{
    public class DAL_PurchaseOrder
    {
        private String errMsg;

        SqlConnection myConnect = DAL_Connection.GetConnection();

        private string _PO_ID, _PO_CompanyName, _PO_CompanyEmail, _PO_CompanyContact, _PO_CompanyAddress, _PO_Date, _PO_AdminComment, _ProdID, _OI_ID;

        public DAL_PurchaseOrder()
        {
            this._PO_ID = null;
            this._PO_CompanyName = null;
            this._PO_CompanyEmail = null;
            this._PO_CompanyContact = null;
            this._PO_CompanyAddress = null;
            this._PO_Date = null;
            this._PO_AdminComment = null;
            this._ProdID = null;
            this._OI_ID = null;
        }

        public DAL_PurchaseOrder(string aPO_ID, string aPO_CompanyName, string aPO_CompanyEmail, string aPO_CompanyContact, string aPO_CompanyAddress, string aPO_Date, string aPO_AdminComment, string aProdID, string aOI_ID)
        {
            this._PO_ID = aPO_ID;
            this._PO_CompanyName = aPO_CompanyName;
            this._PO_CompanyEmail = aPO_CompanyEmail;
            this._PO_CompanyContact = aPO_CompanyContact;
            this._PO_CompanyAddress = aPO_CompanyAddress;
            this._PO_Date = aPO_Date;
            this._PO_AdminComment = aPO_AdminComment;
            this._ProdID = aProdID;
            this._OI_ID = aOI_ID;
        }

        public string PO_ID
        {
            get { return _PO_ID; }
            set { _PO_ID = value; }
        }

        public string PO_CompanyName
        {
            get { return _PO_CompanyName; }
            set { _PO_CompanyName = value; }
        }

        public string PO_CompanyEmail
        {
            get { return _PO_CompanyEmail; }
            set { _PO_CompanyEmail = value; }
        }

        public string PO_CompanyContact
        {
            get { return _PO_CompanyContact; }
            set { _PO_CompanyContact = value; }
        }

        public string PO_CompanyAddress
        {
            get { return _PO_CompanyAddress; }
            set { _PO_CompanyAddress = value; }
        }

        public string PO_Date
        {
            get { return _PO_Date; }
            set { _PO_Date = value; }
        }

        public string PO_AdminComment
        {
            get { return _PO_AdminComment; }
            set { _PO_AdminComment = value; }
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

        // Retrieve all
        public DataSet GetAll_PurchaseOrders()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet programData;

            programData = new DataSet();

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

        // Update
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

            //string query = "DELETE PurchaseOrder WHERE PO_ID=@PO_ID";
            string query = "UPDATE PurchaseOrder SET PO_ProcessStatus='Rejected' WHERE PO_ID=@PO_ID";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@PO_ID", PO_ID);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // Delete ACCEPT 
        public int acceptPurchaseOrderStatus(int PO_ID)
        {
            int result = 0;

            string query = "UPDATE PurchaseOrder SET PO_ProcessStatus='Accepted' WHERE PO_ID=@PO_ID";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@PO_ID", PO_ID);

            result = cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // INSERT to be used by supplier
        public int createCustomerOrder(string PO_ID, string PO_CompanyName, string PO_CompanyEmail, string PO_CompanyContact, string PO_CompanyAddress, string PO_Date, string OI_ID, string ProdID)
        {
            int result = 0;

            //string query = "INSERT INTO CustomerOrder(CO_Name) VALUES(@name)";
            string query = "INSERT INTO CustomerOrder(CO_CompanyName, CO_CompanyEmail, CO_CompanyContact, CO_CompanyAddress, CO_Date, OI_ID, ProdID, PO_ID) VALUES(@name, @email, @contact, @address, @date, @OI_ID, @ProdID, @PO_ID) SELECT PO_CompanyName, PO_CompanyEmail, PO_CompanyContact, PO_CompanyAddress, PO_Date, OI_ID, ProdID, PO_ID FROM PurchaseOrder WHERE PO_ID=@PO_ID";
            myConnect.Open();
            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@name", PO_CompanyName);
            cmd.Parameters.AddWithValue("@email", PO_CompanyEmail);
            cmd.Parameters.AddWithValue("@contact", PO_CompanyContact);
            cmd.Parameters.AddWithValue("@address", PO_CompanyAddress);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(PO_Date));
            cmd.Parameters.AddWithValue("@OI_ID", OI_ID);
            cmd.Parameters.AddWithValue("@ProdID", ProdID);
            cmd.Parameters.AddWithValue("@PO_ID", PO_ID);



            result += cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }

        // INSERT to be used by company
        public int insertPurchaseOrder(string name, string email, string contact, string address, string date)
        {
            int result = 0;

            string query = "INSERT PurchaseOrder(PO_CompanyName, PO_CompanyEmail, PO_CompanyContact, PO_CompanyAddress, PO_Date) VALUES(@name, @email, @contact, @address, @date)";

            myConnect.Open();
            SqlCommand cmd = new SqlCommand(query, myConnect);
            //cmd.Parameters.AddWithValue("PO_ID", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(date));

            result += cmd.ExecuteNonQuery();



            myConnect.Close();

            return result;
        }



        // Search Filter
        public DataTable SearchPurchaseOrder(string name)
        {
            string queryStr = "SELECT * FROM PurchaseOrder WHERE PO_CompanyName LIKE '%' +@name+ '%' ";

            myConnect.Open();

            SqlCommand cmd = new SqlCommand(queryStr, myConnect);
            cmd.Parameters.AddWithValue("@name", name);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            return dt;
        }

        // DDL process filter
        public DataTable filter_ProcessStatus(string status)
        {
            string queryStr;

            if (status == "Process Status")
            {
                queryStr = "SELECT * FROM PurchaseOrder";
            }
            else
            {
                queryStr = "SELECT * FROM PurchaseOrder WHERE PO_ProcessStatus = '" + status + "'";
            }

            SqlCommand cmd = new SqlCommand(queryStr, myConnect);
            myConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            myConnect.Close();

            return dt;
        }







        // Retrieve row by ID
        public List<DAL_PurchaseOrder> GetSinglePurchaseOrders(string ID)
        {
            List<DAL_PurchaseOrder> PO_List = new List<DAL_PurchaseOrder>();

            string queryStr = "SELECT * FROM PurchaseOrder WHERE PO_ID = @PO_ID";

            myConnect.Open();
            SqlCommand cmd = new SqlCommand(queryStr, myConnect);

            cmd.Parameters.AddWithValue("@PO_ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string PO_ID = dr["PO_ID"].ToString();
                string PO_CompanyName = dr["PO_CompanyName"].ToString();
                string PO_CompanyEmail = dr["PO_CompanyEmail"].ToString();
                string PO_CompanyContact = dr["PO_CompanyContact"].ToString();
                string PO_CompanyAddress = dr["PO_CompanyAddress"].ToString();
                string PO_Date = dr["PO_Date"].ToString();
                string PO_AdminComment = dr["PO_AdminComment"].ToString();
                string ProdID = dr["ProdID"].ToString();
                string OI_ID = dr["OI_ID"].ToString();

                DAL_PurchaseOrder obj = new DAL_PurchaseOrder(PO_ID, PO_CompanyName, PO_CompanyEmail, PO_CompanyContact, PO_CompanyAddress, PO_Date, _PO_AdminComment, ProdID, OI_ID);

                PO_List.Add(obj);
            }

            myConnect.Close();
            return PO_List;
        }









    }

}










   