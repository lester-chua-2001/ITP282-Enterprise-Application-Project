using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EAP_Company_FixTech.DAL.Tjandra;
using System.Data;

namespace EAP_Company_FixTech.Web.Admin.Tjandra
{
    public partial class PurchaseOrder_ViewMore : System.Web.UI.Page
    {
        DAL_OrderItem obj = new DAL_OrderItem();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            DataTable ds;
            ds = obj.GetAll_OrderItem();
            gv_OrderItems.DataSource = ds;
            gv_OrderItems.DataBind();

            //gv_OrderItems.FooterRow.Cells[2].Text = "Total Amount";
            //gv_OrderItems.FooterRow.Cells[3].Text = ds.Compute("SUM(OI_Price)", "").ToString();
            lbl_Total.Text = ds.Compute("SUM(OI_Price)", "").ToString();
        }



    }
}