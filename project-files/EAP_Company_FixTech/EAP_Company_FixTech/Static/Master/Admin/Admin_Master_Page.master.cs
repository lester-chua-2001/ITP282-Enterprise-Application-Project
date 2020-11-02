using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class static_Master_Admin_Admin_Master_Page : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtn_Dashboard_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Dashboard/Dashboard.aspx");
    }

    protected void lbtn_Order_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Tjandra/Order.aspx");

    }

    protected void lbtn_ViewOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Tjandra/PurchaseOrder.aspx");

    }

    protected void btn_getDO_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Nelson/DeliveryOrderList.aspx");
    }

    protected void lbtn_Payment_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Lester/ListOfSupplierInvoice.aspx");

    }



}
