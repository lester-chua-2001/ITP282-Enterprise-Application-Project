using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EAP_Supplier_Votech.DAL.Tjandra;
using System.Data;
using System.Net.Mail;

namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class CustomerOrder : System.Web.UI.Page
    {
        DAL_CustomerOrder obj = new DAL_CustomerOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindGridView();
            }

            if (!Page.IsPostBack)
            {

                ddl_Status.Items.Insert(0, new ListItem("Delivery Status", "Delivery Status")); //Text, value
                ddl_PaymentStatus.Items.Insert(0, new ListItem("Payment Status", "Payment Status"));
            }

        }

        private void BindGridView()
        {
            DataSet ds;
            ds = obj.GetAll_CustomerOrders();
            gv_CustomerOrder.DataSource = ds;
            gv_CustomerOrder.DataBind();
        }

        protected void gv_CustomerOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newPageIndex = e.NewPageIndex;
            gv_CustomerOrder.PageIndex = newPageIndex;
            BindGridView();
        }

        protected void gv_CustomerOrder_RowDeleting(object sender, GridViewDeleteEventArgs e) //Archive
        {
            // =========== Delete =============
            int selectedRow = e.RowIndex;
            int CO_ID = (int)gv_CustomerOrder.DataKeys[selectedRow].Value;
            BindGridView();
            obj.deletePurchaseOrder(CO_ID);

            Response.Redirect("CustomerOrder.aspx");
        }

        protected void gv_CustomerOrder_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int selectedRow = e.RowIndex;
            int CO_ID = (int)gv_CustomerOrder.DataKeys[selectedRow].Value;

            GridViewRow row = (GridViewRow)gv_CustomerOrder.Rows[selectedRow];
            TextBox comment = (TextBox)row.FindControl("tb_AdminComment");

            BindGridView();

            int result = 0;
            result = obj.updatePurchaseOrder(CO_ID, comment.Text);

            if (result > 0)
            {
                Response.Write("<script>alert('Successfully Updated!');</script>");
            }
            else
            {
                Response.Write("<script>alert('FAILED!');</script>");

            }

            gv_CustomerOrder.EditIndex = -1;

            Response.Redirect("CustomerOrder.aspx");
        }

        protected void gv_CustomerOrder_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_CustomerOrder.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void gv_CustomerOrder_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_CustomerOrder.EditIndex = -1;
            BindGridView();
        }

        protected void gv_CustomerOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gv_CustomerOrder.SelectedRow;
            string CO_ID = row.Cells[0].Text;

            Response.Redirect("~/Web/Admin/Tjandra/CustomerOrder_ViewMore.aspx?CO_ID=" + CO_ID);
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerOrder.aspx");
        }

        protected void btn_CompletedOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompletedOrder.aspx");

        }


        protected void btn_SearchName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.SearchPurchaseOrder(tb_SearchName.Text);

            gv_CustomerOrder.DataSource = dt;
            gv_CustomerOrder.DataBind();
        }

        protected void ddl_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var obj = new DAL_CustomerOrder();
            dt = obj.filterCustomerOrder_DDL(ddl_Status.SelectedItem.Text);
            gv_CustomerOrder.DataSource = dt;
            gv_CustomerOrder.DataBind();
        }

        protected void ddl_PaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var obj = new DAL_CustomerOrder();
            dt = obj.filterCO_PaymentStatus(ddl_PaymentStatus.SelectedItem.Text);
            gv_CustomerOrder.DataSource = dt;
            gv_CustomerOrder.DataBind();
        }


        protected void btn_Archived_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerOrder_Archived.aspx");
        }
    }
}