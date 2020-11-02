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

    //protected void lbtn_Dashboard_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/Web/Admin/Dashboard/Dashboard.aspx");
    //}

    protected void lbtn_Order_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Tjandra/PurchaseOrder.aspx");

    }

    protected void lbtn_CustomerOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Web/Admin/Tjandra/CustomerOrder.aspx");
    }

    protected void lbtn_Invoice_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Web/Admin/Lester/SendingInvoice.aspx");
    }
    protected void lbtn_PaymentStatus_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Web/Admin/Lester/ListOfInvoice.aspx");
    }
    protected void lbtn_PaymentDetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Web/Admin/Lester/PaymentDetails.aspx");
    }


    protected void btnDeliveryOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Admin/Nelson/DeliveryOrder.aspx");

    }


}
