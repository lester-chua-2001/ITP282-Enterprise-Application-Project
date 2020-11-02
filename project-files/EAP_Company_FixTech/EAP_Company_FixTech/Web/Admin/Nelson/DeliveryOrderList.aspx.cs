using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAP_Company_FixTech.DAL.Nelson;
using EAP_Company_FixTech.BLL.Nelson;
using System.Data;

namespace EAP_Company_FixTech.Web.Admin
{
    public partial class DeliveryOrderList : System.Web.UI.Page
    {
        BLL_SupplierNelson DO = new BLL_SupplierNelson();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            DataSet ds;
            ds = DO.getAllDeliveryOrders();
            gvDeliveryOrder.DataSource = ds;
            gvDeliveryOrder.DataBind();
        }

        protected void gvDeliveryOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRow = gvDeliveryOrder.SelectedIndex;
            GridViewRow row = gvDeliveryOrder.Rows[selectedRow];
            Response.Redirect("~/Web/Admin//GetDeliveryOrder.aspx?DO_ID=" + row.Cells[0].Text);
        }
    }
}