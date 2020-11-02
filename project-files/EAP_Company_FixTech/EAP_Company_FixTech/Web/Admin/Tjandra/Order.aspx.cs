using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using EAP_Company_FixTech.BLL.Tjandra;
using EAP_Company_FixTech.DAL.Tjandra;


namespace EAP_Company_FixTech.Web.Admin
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tb_CompanyName.Text = "FixTech";

            if (!IsPostBack)
            {
                bind();
            }
        }

        private void bind()
        {
            //DAL_OrderItem obj = new DAL_OrderItem();

            //DataSet ds;
            //ds = obj.GetAll_OrderItem();
            //gv_OrderItem.DataSource = ds;
            //gv_OrderItem.DataBind();
            BLL_Inventory obj = new BLL_Inventory();
            DataSet ds;
            ds = obj.GetAll_Inventory();
            gv_OrderItem.DataSource = ds;
            gv_OrderItem.DataBind();
        }

        protected void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            BLL_PurchaseOrder obj = new BLL_PurchaseOrder();
            obj.insertPurchaseOrder(tb_CompanyName.Text, tb_CompanyEmail.Text, tb_CompanyContact.Text, tb_CompanyAddress.Text, DateTime.Now.ToString());

            obj.insertOrderItems(DateTime.Now.ToString()); // This is for Order Item

            ClientScript.RegisterStartupScript(this.GetType(), "randomtext", "alertMe()", true);
        }

        protected void gv_OrderItem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newPageIndex = e.NewPageIndex;
            gv_OrderItem.PageIndex = newPageIndex;
            bind();
        }

        protected void gv_OrderItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRow = gv_OrderItem.SelectedIndex;
            GridViewRow row = gv_OrderItem.Rows[selectedRow];


            BLL_OrderItem obj = new BLL_OrderItem();
            //string Id = row.Cells[0].Text;

            string ProdName = row.Cells[1].Text;
            string ProdDesc = row.Cells[2].Text;
            string ProdPrice = row.Cells[3].Text;

            obj.createOrderItems(ProdName, ProdDesc, ProdPrice);


          
            DAL_OrderItem obj2 = new DAL_OrderItem();
            obj2.insertOrderItem(ProdName, ProdDesc,ProdPrice);
        }


    }
}