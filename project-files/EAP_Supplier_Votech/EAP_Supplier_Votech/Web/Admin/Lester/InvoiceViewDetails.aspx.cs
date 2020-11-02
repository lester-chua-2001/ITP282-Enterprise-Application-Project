using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.Web.Admin.Lester
{
    public partial class InvoiceViewDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindInvoiceViewMoreList();
            }
        }
        private void BindInvoiceViewMoreList()
        {
            DAL_InvoiceViewDetails obj = new DAL_InvoiceViewDetails();
            DataSet ds;
            ds = obj.getInvoiceViewMore();
            gvViewDetails.DataSource = ds;
            gvViewDetails.DataBind();
        }
    }
}