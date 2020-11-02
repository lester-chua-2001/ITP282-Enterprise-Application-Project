using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAP_Supplier_Votech.DAL.Lester;
using System.Data;

namespace EAP_Supplier_Votech.Web.Admin.Lester
{
    public partial class InvoiceCreated : System.Web.UI.Page
    {
        DAL_CreateInvoice obj = new DAL_CreateInvoice();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }
        protected void bind()
        {
            string InvoiceNum = Request.QueryString["InvoiceNum"];
            List<DAL_CreateInvoice> Invoice_List = new List<DAL_CreateInvoice>();
            Invoice_List = obj.GetInvoiceCreated();

            lbl_InvoiceNum.Text = InvoiceNum;
            lbl_CompanyEmail.Text = Invoice_List[0].CO_CompanyEmail.ToString();
            lbl_CompanyName.Text = Invoice_List[0].CO_CompanyName.ToString();
            lbl_Companycontact.Text = Invoice_List[0].CO_CompanyContact.ToString();
            lbl_CompanyAddress.Text = Invoice_List[0].CO_CompanyAddress.ToString();
            lbl_Date.Text = Invoice_List[0].InvoiceDate.ToString();


            //Gridview codes

            DAL_InvoiceOrderItem item = new DAL_InvoiceOrderItem();
            DataSet ds;
            ds = item.GetAllInvoiceOrderItem();
            gv_InvoiceOrderItem.DataSource = ds;
            gv_InvoiceOrderItem.DataBind();


            //gv_InvoiceOrderItem.FooterRow.Cells[2].Text = "Total Amount";
            //gv_InvoiceOrderItem.FooterRow.Cells[3].Text = dt.Compute("SUM(OI_Price)", "").ToString();

            //lbl_Total.Text = dt.Compute("SUM(OI_Price)", "").ToString();
        }
    }
}