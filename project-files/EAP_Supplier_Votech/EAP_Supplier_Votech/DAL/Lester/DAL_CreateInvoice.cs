using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EAP_Supplier_Votech.DAL.Lester
{
    public class DAL_CreateInvoice
    {
        SqlConnection myConnect = DAL_Connection.GetConnection();

        private string _CO_ID, _CO_CompanyName, _CO_CompanyEmail, _CO_CompanyContact, _CO_CompanyAddress, _CO_Date, _CO_AdminComment, _CO_Archive, _ProdID, _OI_ID, _PO_ID, _InvoiceNum, _InvoiceDate;

        public DAL_CreateInvoice()
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
            this._InvoiceNum = null;
            this._InvoiceDate = null;
        }

        public DAL_CreateInvoice(string aCO_ID, string aCO_CompanyName, string aCO_CompanyEmail, string aCO_CompanyContact, string aCO_CompanyAddress, string aCO_Date, string aCO_AdminComment, string aCO_Archive, string aProdID, string aOI_ID, string aPO_ID, string aInvoiceNum, string aInvoiceDate)
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
            this._InvoiceNum = aInvoiceNum;
            this._InvoiceDate = aInvoiceDate;
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
        public string InvoiceNum
        {
            get { return _InvoiceNum; }
            set { _InvoiceNum = value; }
        }
        public string InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }

        public int createinvoice(string InvoiceDate, decimal InvoiceTotalAmt, int CO_ID)
        {
            int result = 0;

            string query = "INSERT INTO Invoice(InvoiceDate, InvoiceTotalAmt, CO_ID) VALUES(@InvoiceDate, @InvoiceTotalAmt, @CO_ID)";

            SqlCommand cmd = new SqlCommand(query, myConnect);
            cmd.Parameters.AddWithValue("@InvoiceDate", DateTime.ParseExact(InvoiceDate, "dd/MM/yyyy", null));
            cmd.Parameters.AddWithValue("@InvoiceTotalAmt", InvoiceTotalAmt);
            cmd.Parameters.AddWithValue("@CO_ID", CO_ID);

            myConnect.Open();

            cmd.ExecuteNonQuery();

            myConnect.Close();

            return result;
        }


        // Retrieve row by CO_ID
        public List<DAL_CreateInvoice> GetInvoiceCreated()
        {
            List<DAL_CreateInvoice> Invoice_List = new List<DAL_CreateInvoice>();

            string queryStr = "SELECT C.* , I.InvoiceNum, I.InvoiceDate FROM CustomerOrder C  JOIN Invoice I on I.CO_ID = C.CO_ID";

            myConnect.Open();
            SqlCommand cmd = new SqlCommand(queryStr, myConnect);

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
                string InvoiceNum = dr["InvoiceNum"].ToString();
                string InvoiceDate = dr["InvoiceDate"].ToString();


                DAL_CreateInvoice obj = new DAL_CreateInvoice(CO_ID, CO_CompanyName, CO_CompanyEmail, CO_CompanyContact, CO_CompanyAddress, CO_Date, CO_AdminComment, CO_Archive, ProdID, OI_ID, PO_ID, InvoiceNum, InvoiceDate);

                Invoice_List.Add(obj);
            }

            myConnect.Close();
            return Invoice_List;
        }

        
    }
}