using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EAP_Company_FixTech.DAL.Tjandra;
using System.Data;

namespace EAP_Company_FixTech.Web.Admin
{
    public partial class PurchaseOrder : System.Web.UI.Page
    {
        DAL_PurchaseOrder obj = new DAL_PurchaseOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            DataTable ds;
            ds = obj.GetAll_PurchaseOrders();
            gv_PurchaseOrder.DataSource = ds;
            gv_PurchaseOrder.DataBind();


        }

        protected void gv_PurchaseOrder_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int selectedRow = e.RowIndex;
            int PO_ID = (int)gv_PurchaseOrder.DataKeys[selectedRow].Value;

            GridViewRow row = (GridViewRow)gv_PurchaseOrder.Rows[selectedRow];
            TextBox comment = (TextBox)row.FindControl("tb_AdminComment");

            BindGridView();

            int result = 0;
            result = obj.updatePurchaseOrder(PO_ID, comment.Text);

            if (result > 0)
            {
                Response.Write("<script>alert('Successfully Updated!');</script>");
            }
            else
            {
                Response.Write("<script>alert('FAILED!');</script>");

            }


            gv_PurchaseOrder.EditIndex = -1;

            Response.Redirect("PurchaseOrder.aspx");
        }

        protected void gv_PurchaseOrder_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_PurchaseOrder.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void gv_PurchaseOrder_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_PurchaseOrder.EditIndex = -1;
            BindGridView();
        }

        protected void gv_PurchaseOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newPageIndex = e.NewPageIndex;
            gv_PurchaseOrder.PageIndex = newPageIndex;
            BindGridView();
        }

        protected void gv_PurchaseOrder_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // =========== Delete ============= //Update the status process rejected 
            int selectedRow = e.RowIndex;
            int PO_ID = (int)gv_PurchaseOrder.DataKeys[selectedRow].Value;
            BindGridView();
            obj.deletePurchaseOrder(PO_ID);

            Response.Redirect("PurchaseOrder.aspx");
        }

        protected void gv_PurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gv_PurchaseOrder.SelectedRow;
            string PO_ID = row.Cells[0].Text;

            Response.Redirect("~/Web/Admin/Tjandra/PurchaseOrder_ViewMore.aspx?PO_ID=" + PO_ID);
        }
    }
}