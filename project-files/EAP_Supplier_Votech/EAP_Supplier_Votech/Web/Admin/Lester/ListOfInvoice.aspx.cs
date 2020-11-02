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
    public partial class PaymentStatus : System.Web.UI.Page
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
            DAL_PaymentStatus obj = new DAL_PaymentStatus();
            DataSet ds;
            ds = obj.GetAllCustomerOrders();
            gv_PaymentStatus.DataSource = ds;
            gv_PaymentStatus.DataBind();
        }

        protected void gv_PaymentStatus_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_PaymentStatus.EditIndex = e.NewEditIndex;
            BindPaymentStatusList();
        }

        protected void gv_PaymentStatus_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int updatepayment = 0;
            DAL_PaymentStatus ps = new DAL_PaymentStatus();
            string CO_ID = gv_PaymentStatus.DataKeys[e.RowIndex].Value.ToString();
            GridViewRow row = gv_PaymentStatus.SelectedRow;

            //string CO_ID = (((TextBox)row.Cells[0].Controls[0]).Text);
            TextBox tb = (TextBox)gv_PaymentStatus.Rows[e.RowIndex].FindControl("txtCOPaymentStatus");
            string CO_PaymentStatus = tb.Text;
            updatepayment = ps.PaymentStatusUpdate(CO_ID, CO_PaymentStatus);
            if (updatepayment > 0)
            {
                Response.Write("<script>alert('Payment Status updated successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Payment Status NOT updated');</script>");
            }
            gv_PaymentStatus.EditIndex = -1;
            BindPaymentStatusList();
        }


        protected void gv_PaymentStatus_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_PaymentStatus.EditIndex = -1;
            BindPaymentStatusList();
        }

        protected void gv_PaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gv_PaymentStatus.SelectedRow;
            int InvoiceNum = Convert.ToInt32(row.Cells[1].Text);
            Response.Redirect("InvoiceCreated.aspx?InvoiceNum=" + InvoiceNum);
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            DAL_PaymentStatus obj = new DAL_PaymentStatus();
            DataTable dt = new DataTable();
            dt = obj.searchcompanyname(tb_search.Text);

            gv_PaymentStatus.DataSource = dt;
            gv_PaymentStatus.DataBind();
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfInvoice.aspx");
        }
    }
}