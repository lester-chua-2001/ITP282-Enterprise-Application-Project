using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EAP_Supplier_Votech.DAL.Lester;


namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindPaymentStatusList();
            }
        }

        private void BindPaymentStatusList()
        {
            DAL_SendingInvoice obj = new DAL_SendingInvoice();
            DataSet ds;
            ds = obj.GetAllInvoice();
            gvInvoice.DataSource = ds;
            gvInvoice.DataBind();
        }

        protected void gvInvoice_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;

            if (e.CommandName == "View Details")
            {
                int CO_ID = Convert.ToInt32(gvr.Cells[0].Text);
                Response.Redirect("InvoiceViewDetails.aspx?CO_ID=" + CO_ID);
            }
            if (e.CommandName == "Generate Invoice")
            {
                //int InvoiceNum = Convert.ToInt32(gvr.Cells[1].Text);
                Response.Redirect("CreateInvoice.aspx?CO_ID=" + gvr.Cells[0].Text);
            }
        }
        protected void btn_search_Click(object sender, EventArgs e)
        {
            DAL_SendingInvoice obj = new DAL_SendingInvoice();
            DataTable dt = new DataTable();
            dt = obj.searchcompanyname(tb_search.Text);

            gvInvoice.DataSource = dt;
            gvInvoice.DataBind();
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendingInvoice.aspx");
        }
    }
}