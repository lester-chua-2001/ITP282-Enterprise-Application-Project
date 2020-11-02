using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EAP_Supplier_Votech.DAL.Tjandra;
using System.Data;
using System.IO;

namespace EAP_Supplier_Votech.Web.Admin.Tjandra
{
    public partial class CompletedOrder : System.Web.UI.Page
    {

        DAL_CustomerOrder obj = new DAL_CustomerOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            DataSet ds;
            ds = obj.GetCompleted_CustomerOrders();
            gv_CompletedOrder.DataSource = ds;
            gv_CompletedOrder.DataBind();
        }


        protected void btn_SearchName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = obj.SearchCompletedOrders(tb_SearchName.Text);

            gv_CompletedOrder.DataSource = dt;
            gv_CompletedOrder.DataBind();
        }

        protected void btn_Refresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompletedOrder.aspx");
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        protected void btn_Excel_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Report_CustomerOrders.xls"));
            Response.ContentType = "application/ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gv_CompletedOrder.AllowPaging = false;
            BindGridView();
            //Change the Header Row back to white color
            gv_CompletedOrder.HeaderRow.Style.Add("background-color", "#FFFFFF");
            //Applying stlye to gridview header cells
            for (int i = 0; i < gv_CompletedOrder.HeaderRow.Cells.Count; i++)
            {
                gv_CompletedOrder.HeaderRow.Cells[i].Style.Add("background-color", "#df5015");
            }
            gv_CompletedOrder.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }
    }
}