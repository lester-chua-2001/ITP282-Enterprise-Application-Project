using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using EAP_Supplier_Votech.DAL.Tjandra;
using System.Data;

namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class CustomerOrder_Archived : System.Web.UI.Page
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
            ds = obj.GetAll_CustomerOrdersArchived();
            gv_CustomerOrderArchived.DataSource = ds;
            gv_CustomerOrderArchived.DataBind();
        }

        protected void gv_CustomerOrderArchived_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ========= Restore =========
            int selectedRowIndex = gv_CustomerOrderArchived.SelectedIndex;
            int CO_ID = Convert.ToInt32(gv_CustomerOrderArchived.DataKeys[selectedRowIndex].Value);
            BindGridView();
            obj.restoreCustomerOrder(CO_ID);
            Response.Redirect("CustomerOrder_Archived.aspx");

        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerOrder.aspx");
        }

        //protected void gv_CustomerOrderArchived_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    // =========== Restore =============
        //    int selectedRow = e.RowIndex;
        //    int CO_ID = (int)gv_CustomerOrderArchived.DataKeys[selectedRow].Value;
        //    BindGridView();
        //    obj.restoreCustomerOrder(CO_ID);

        //    Response.Redirect("CustomerOrder_Archived.aspx");
        //}
    }
}