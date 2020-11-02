using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EAP_Supplier_Votech.BLL.Lester;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.Web.Admin.Lester
{
    public partial class PaymentDetails : System.Web.UI.Page
    {  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindPaymentDetailsList();
            }
        }
        private void BindPaymentDetailsList()
        {
            DAL_PaymentDetails obj = new DAL_PaymentDetails();
            DataSet ds;
            ds = obj.getAllPaymentDetails();
            gv_PaymentDetails.DataSource = ds;
            gv_PaymentDetails.DataBind();
        }
        
    }
}