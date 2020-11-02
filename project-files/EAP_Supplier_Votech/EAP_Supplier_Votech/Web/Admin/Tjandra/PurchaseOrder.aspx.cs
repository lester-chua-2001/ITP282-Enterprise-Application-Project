using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EAP_Supplier_Votech.DAL.Tjandra;
using System.Data;
using System.Net.Mail;


namespace EAP_Supplier_Votech.Web
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

            if (!Page.IsPostBack)
            {

                ddl_ProcessStatus.Items.Insert(0, new ListItem("Process Status", "Process Status"));
            }

        }        

        private void BindGridView()
        {
            DataSet ds;
            ds = obj.GetAll_PurchaseOrders();
            gv_PurchaseOrder.DataSource = ds;
            gv_PurchaseOrder.DataBind();

        }


        protected void gv_PurchaseOrder_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // =========== Sending Email =============       

            string to, from, subject, body;
            to = "fixtech.eap@gmail.com";
            from = "votech.eap@gmail.com";
            subject = "[Auto Generated Email] Order Cancelled";
            body = "Dear customer, we regret to inform you that your order has not been successful. Please contact FixTech support team for clarifications. Thank you.";

            MailMessage message = new MailMessage(from, to, subject, body);
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("votech.eap@gmail.com", "votechvotech");
            client.Send(message);

            // =========== Delete ============= //Update the status process rejected 
            int selectedRow = e.RowIndex;
            int PO_ID = (int)gv_PurchaseOrder.DataKeys[selectedRow].Value;
            BindGridView();
            obj.deletePurchaseOrder(PO_ID);

            Response.Redirect("PurchaseOrder.aspx");

          

        }

        protected void gv_PurchaseOrder_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int selectedRow = e.RowIndex;
            int PO_ID = (int)gv_PurchaseOrder.DataKeys[selectedRow].Value;

            GridViewRow row = (GridViewRow)gv_PurchaseOrder.Rows[selectedRow];
            TextBox comment = (TextBox)row.FindControl("tb_AdminComment");

            //TextBox styling = (TextBox)row.FindControl("tb_ProcessStatus");

            //if (styling.Text == "Accepted")
            //{
            //    styling.Attributes.Add("style", "color:green;");
            //}

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

        protected void btn_SearchName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.SearchPurchaseOrder(tb_SearchName.Text);

            gv_PurchaseOrder.DataSource = dt;
            gv_PurchaseOrder.DataBind();
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("PurchaseOrder.aspx");
        }

        protected void gv_PurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gv_PurchaseOrder.SelectedRow;
            string PO_ID = row.Cells[0].Text;

            Response.Redirect("~/Web/Admin/Tjandra/PurchaseOrder_ViewMore.aspx?PO_ID=" + PO_ID);
        }

        protected void ddl_ProcessStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var obj = new DAL_PurchaseOrder();
            dt = obj.filter_ProcessStatus(ddl_ProcessStatus.SelectedItem.Text);
            gv_PurchaseOrder.DataSource = dt;
            gv_PurchaseOrder.DataBind();
        }
    }
}