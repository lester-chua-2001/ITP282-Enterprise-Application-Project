using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAP_Company_FixTech.DAL.Lester;
using System.Data;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;
using EAP_Company_FixTech.BLL.Lester;

namespace EAP_Supplier_Votech.Web.Admin.Lester
{
    public partial class InvoiceCreated : System.Web.UI.Page
    {
        DAL_Access_Supplier_Votech DAL = new DAL_Access_Supplier_Votech();
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
            BLL_Supplier_Votech obj = new BLL_Supplier_Votech();
            DAL_CreateInvoice[] Invoice_List;
            Invoice_List = obj.GetInvoiceCreated();

            lbl_InvoiceNum.Text = InvoiceNum;
            lbl_CompanyEmail.Text = Invoice_List[0].CO_CompanyEmail.ToString();
            lbl_CompanyName.Text = Invoice_List[0].CO_CompanyName.ToString();
            lbl_Companycontact.Text = Invoice_List[0].CO_CompanyContact.ToString();
            lbl_CompanyAddress.Text = Invoice_List[0].CO_CompanyAddress.ToString();
            lbl_Date.Text = Invoice_List[0].InvoiceDate.ToString();


            //Gridview codes

            DAL_Access_Supplier_Votech item = new DAL_Access_Supplier_Votech();
            DataSet ds;
            ds = item.getInvoiceOrderItem();
            gv_InvoiceOrderItem.DataSource = ds;
            gv_InvoiceOrderItem.DataBind();


            //gv_InvoiceOrderItem.FooterRow.Cells[2].Text = "Total Amount";
            //gv_InvoiceOrderItem.FooterRow.Cells[3].Text = ds.Compute("SUM(OI_Price)", "").ToString();

            //lbl_Total.Text = ds.Compute("SUM(OI_Price)", "").ToString();
        }
    }
}