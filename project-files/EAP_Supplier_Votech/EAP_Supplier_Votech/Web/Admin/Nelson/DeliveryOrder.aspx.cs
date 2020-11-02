using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAP_Supplier_Votech.DAL.Nelson;
using System.Data;

namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class DeliveryOrder : System.Web.UI.Page
    {
        DAL_DeliveryOrder DO = new DAL_DeliveryOrder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Bind();
            }
        }

        private void Bind()
        {
            DataSet ds = DO.getAllDeliveryOrders();
            gvDeliveryOrder.DataSource = ds;
            gvDeliveryOrder.DataBind();
        }

        protected void gvDeliveryOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvDeliveryOrder.SelectedRow;
            string DO_ID = row.Cells[0].Text;
            Response.Redirect("~/Web/Admin/Nelson/DeliveryOrder_View.aspx?DO_ID=" + DO_ID);
        }

        protected void gvDeliveryOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newPageIndex = e.NewPageIndex;
            gvDeliveryOrder.PageIndex = newPageIndex;
            Bind();
        }

        protected void gvDeliveryOrder_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int result = 0;
            int selectedRow = e.RowIndex;
            int DO_ID = (int)gvDeliveryOrder.DataKeys[selectedRow].Value;
            Bind();
            result = DO.deleteDeliveryOrder(DO_ID);
            if (result > 0)
            {
                Response.Write("<script>alert('Delivery Order Deleted!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Delivery Order NOT Deleted');</script>");
            }
            Response.Redirect("DeliveryOrder.aspx");
        }

        protected void gvDeliveryOrder_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDeliveryOrder.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void gvDeliveryOrder_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int result = 0;
            int selectedRow = e.RowIndex;
            int DO_ID = (int)gvDeliveryOrder.DataKeys[selectedRow].Value;

            GridViewRow row = (GridViewRow)gvDeliveryOrder.Rows[selectedRow];
            TextBox remarks = (TextBox)row.FindControl("tb_DO_Remarks");
            Bind();
            result = DO.updateDeliveryOrder(DO_ID, remarks.Text);

            if (result > 0)
            {
                Response.Write("<script>alert('Remarks Updated');</script>");
            }
            else
            {
                Response.Write("<script>alert('Remarks NOT Updated');</script>");

            }

            gvDeliveryOrder.EditIndex = -1;
            Response.Redirect("DeliveryOrder.aspx");
        }

        protected void gvDeliveryOrder_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDeliveryOrder.EditIndex = -1;
            Bind();
        }
    }
}