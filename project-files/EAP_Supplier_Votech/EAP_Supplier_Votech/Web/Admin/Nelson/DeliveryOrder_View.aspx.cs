using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using EAP_Supplier_Votech.DAL.Nelson;
using EAP_Supplier_Votech.DAL.Tjandra;

namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class DeliveryOrder_View : System.Web.UI.Page
    {
        DAL_DeliveryOrder DO = new DAL_DeliveryOrder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            string DO_ID = Request.QueryString["DO_ID"];
            List<DAL_DeliveryOrder> DO_List = new List<DAL_DeliveryOrder>();
            DO_List = DO.getDeliveryOrder(DO_ID);

            tb_DO_ID.Text = DO_ID;
            tb_CompanyEmail.Text = DO_List[0].DO_CompanyEmail.ToString();
            tb_CompanyName.Text = DO_List[0].DO_CompanyName.ToString();
            tb_CompanyContact.Text = DO_List[0].DO_CompanyContact.ToString();
            tb_CompanyAddress.Text = DO_List[0].DO_CompanyAddress.ToString();


            DAL_OrderItem oi = new DAL_OrderItem();
            DataTable ds = oi.GetAll_OrderItem();
            gvDeliveryOrderItems.DataSource = ds;
            gvDeliveryOrderItems.DataBind();
        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeliveryOrder.aspx");
        }
    }
}