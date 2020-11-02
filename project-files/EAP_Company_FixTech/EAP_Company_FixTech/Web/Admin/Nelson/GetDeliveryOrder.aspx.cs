using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EAP_Company_FixTech.BLL.Nelson;
using EAP_Company_FixTech.DAL.Nelson;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;

namespace EAP_Company_FixTech.Web.Admin
{
    public partial class GetDeliveryOrder : System.Web.UI.Page
    {
        DAL_SupplierNelson DO = new DAL_SupplierNelson();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            string DO_ID = Request.QueryString["DO_ID"];
            BLL_SupplierNelson obj = new BLL_SupplierNelson();
            DAL_DeliveryOrder[] ds;
            ds = obj.getDeliveryOrder(DO_ID);
            gvDeliveryOrderItems.DataSource = ds;
            gvDeliveryOrderItems.DataBind();
        }
    }
}