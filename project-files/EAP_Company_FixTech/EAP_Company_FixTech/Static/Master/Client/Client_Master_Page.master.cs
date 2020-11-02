using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class static_Master_Admin_Admin_Master_Page : System.Web.UI.MasterPage
{
    //protected void Page_Load(object sender, EventArgs e)
    //{

    //}

    //protected void lbtn_Contact_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/Web/Support/Inquiry.aspx");

    //}

    protected void lbtn_Index_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/Home/Index.aspx");
    }

    //    protected void lbtn_FAQ_Click(object sender, EventArgs e)
    //    {
    //        Response.Redirect("~/Web/Support/FAQ.aspx");

    //    }

    //    protected void lbtn_Notification_Click(object sender, EventArgs e)
    //    {
    //        Response.Redirect("~/Web/Notification/Notification.aspx");

    //    }

}
