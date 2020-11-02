using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Nelson
{
    public class DAL_DeliveryOrder
    {
        private String errMsg;
        SqlConnection conn = DAL_Connection.GetConnection();

        private string _DO_ID, _DO_CompanyName, _DO_CompanyEmail, _DO_CompanyAddress, _DO_CompanyContact, _DO_Date, _DO_Status, _DO_Remarks, _ProdID, _CO_ID, _OI_ID;

        public DAL_DeliveryOrder()
        {
            this._DO_ID = null;
            this._DO_CompanyName = null;
            this._DO_CompanyEmail = null;
            this._DO_CompanyContact = null;
            this._DO_CompanyAddress = null;
            this._DO_Date = null;
            this._DO_Status = null;
            this._DO_Remarks = null;
            this._ProdID = null;
            this._CO_ID = null;
            this._OI_ID = null;
        }

        public DAL_DeliveryOrder(string DO_ID, string DO_CompanyName, string DO_CompanyEmail, string DO_CompanyAddress, string DO_CompanyContact, string DO_Date, string DO_Status, string DO_Remarks, string ProdID, string CO_ID, string OI_ID)
        {
            this._DO_ID = DO_ID;
            this._DO_CompanyName = DO_CompanyName;
            this._DO_CompanyEmail = DO_CompanyEmail;
            this._DO_CompanyAddress = DO_CompanyAddress;
            this._DO_CompanyContact = DO_CompanyContact;
            this._DO_Date = DO_Date;
            this._DO_Status = DO_Status;
            this._DO_Remarks = DO_Remarks;
            this._ProdID = ProdID;
            this._CO_ID = CO_ID;
            this._OI_ID = OI_ID;
        }

        public string DO_ID
        {
            get { return _DO_ID; }
            set { _DO_ID = value; }
        }

        public string DO_CompanyName
        {
            get { return _DO_CompanyName; }
            set { _DO_CompanyName = value; }
        }

        public string DO_CompanyEmail
        {
            get { return _DO_CompanyEmail; }
            set { _DO_CompanyEmail = value; }
        }

        public string DO_CompanyAddress
        {
            get { return _DO_CompanyAddress; }
            set { _DO_CompanyAddress = value; }
        }

        public string DO_CompanyContact
        {
            get { return _DO_CompanyContact; }
            set { _DO_CompanyContact = value; }
        }

        public string DO_Date
        {
            get { return _DO_Date; }
            set { _DO_Date = value; }
        }

        public string DO_Status
        {
            get { return _DO_Status; }
            set { _DO_Status = value; }
        }

        public string DO_Remarks
        {
            get { return _DO_Remarks; }
            set { _DO_Remarks = value; }
        }

        public string ProdID
        {
            get { return _ProdID; }
            set { _ProdID = value; }
        }

        public string CO_ID
        {
            get { return _CO_ID; }
            set { _CO_ID = value; }
        }

        public string OI_ID
        {
            get { return _OI_ID; }
            set { _OI_ID = value; }
        }

        //To retrieve all Delivery Orders
        public DataSet getAllDeliveryOrders()
        {
            SqlDataAdapter da;
            StringBuilder sql = new StringBuilder();
            DataSet ds = new DataSet();

            sql.AppendLine("SELECT * FROM DeliveryOrder");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ds;

        }

        //To retrieve 1 Delivery Order by DO_ID

        //public DataSet getDeliveryOrder(int DO_ID) //List of Students in FLYTA
        //{
        //    StringBuilder sql;
        //    SqlDataAdapter da;
        //    DataTable ds = new DataTable();
        //    sql = new StringBuilder();
        //    sql.AppendLine("SELECT * FROM DeliveryOrder WHERE DO_ID =@DO_ID");

        //    try
        //    {
        //        da = new SqlDataAdapter(sql.ToString(), conn);
        //        da.SelectCommand.Parameters.AddWithValue("@DO_ID", DO_ID);
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        errMsg = ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return ds;
        //}

        public List<DAL_DeliveryOrder> getDeliveryOrder(string DO_ID)
        {
            List<DAL_DeliveryOrder> DO_List = new List<DAL_DeliveryOrder>();
            string DO_CompanyName, DO_CompanyEmail, DO_CompanyAddress, DO_CompanyContact, DO_Date, DO_Status, DO_Remarks, CO_ID, ProdID, OI_ID;
            string queryStr = "SELECT * FROM DeliveryOrder WHERE DO_ID = @DO_ID";

            conn.Open();
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@DO_ID", DO_ID);
            SqlDataReader dr = cmd.ExecuteReader();

            //check if there are any resultsets
            while (dr.Read())
            {
                DO_ID = dr["DO_ID"].ToString();
                DO_CompanyName = dr["DO_CompanyName"].ToString();
                DO_CompanyEmail = dr["DO_CompanyEmail"].ToString();
                DO_CompanyAddress = dr["DO_CompanyAddress"].ToString();
                DO_CompanyContact = dr["DO_CompanyContact"].ToString();
                DO_Date = dr["DO_Date"].ToString();
                DO_Status = dr["DO_Status"].ToString();
                DO_Remarks = dr["DO_Remarks"].ToString();
                CO_ID = dr["CO_ID"].ToString();
                ProdID = dr["ProdID"].ToString();
                OI_ID = dr["OI_ID"].ToString();

                DAL_DeliveryOrder DO = new DAL_DeliveryOrder(DO_ID, DO_CompanyName, DO_CompanyEmail, DO_CompanyAddress, DO_CompanyContact, DO_Date, DO_Status, DO_Remarks, CO_ID, ProdID, OI_ID);


                DO_List.Add(DO);
            }

            conn.Close();
            return DO_List;
        }

        //Delete DO
        public int deleteDeliveryOrder(int DO_ID)
        {
            int result = 0;

            string query = "DELETE DeliveryOrder WHERE DO_ID=@DO_ID ";

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CO_ID", CO_ID);

            result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }

        //Updates DO Remarks
        public int updateDeliveryOrder(int DO_ID, string DO_Remarks)
        {
            int result = 0;

            string query = "UPDATE DeliveryOrder SET DO_Remarks=@DO_Remarks WHERE DO_ID=@DO_ID";

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DO_ID", DO_ID);
            cmd.Parameters.AddWithValue("@DO_Remarks", DO_Remarks);

            result = cmd.ExecuteNonQuery();

            conn.Close();

            return result;
        }
    }
}
