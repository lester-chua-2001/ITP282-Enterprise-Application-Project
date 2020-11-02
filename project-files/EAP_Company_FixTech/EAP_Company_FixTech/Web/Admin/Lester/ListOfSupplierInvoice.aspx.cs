using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAP_Company_FixTech.BLL.Lester;
using System.Data;

namespace EAP_Company_FixTech.Web.Admin
{
    public partial class TrackingOfPaymentStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                BindPaymentStatusList();
            }
        }
        private void BindPaymentStatusList()
        {
            BLL_Supplier_Votech obj = new BLL_Supplier_Votech();
            DataSet ds;
            ds = obj.GetAllCustomerOrders();
            gv_PaymentStatus.DataSource = ds;
            gv_PaymentStatus.DataBind();
            obj.GetInvoiceCreated();
        }

        protected void gv_PaymentStatus_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;

            if (e.CommandName == "View Invoice")
            {
                int InvoiceNum = Convert.ToInt32(gvr.Cells[1].Text);
                Response.Redirect("InvoiceCreated.aspx?InvoiceNum=" + InvoiceNum);
            }
            if (e.CommandName == "Pay")
            {
                //int InvoiceNum = Convert.ToInt32(gvr.Cells[1].Text);
                Response.Redirect("PayingToSupplier.aspx?InvoiceNum=" + gvr.Cells[1].Text);
            }
        }
    }
}