using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EAP_Supplier_Votech.DAL.Tjandra;
using System.Net.Mail;
using System.Data;

namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class CustomerOrder_ViewMore : System.Web.UI.Page
    {

        DAL_CustomerOrder obj = new DAL_CustomerOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            string CO_ID = Request.QueryString["CO_ID"];
            List<DAL_CustomerOrder> CO_List = new List<DAL_CustomerOrder>();
            CO_List = obj.GetSingleCustomerOrder(CO_ID);

            tb_ID.Text = CO_ID;
            tb_CompanyEmail.Text = CO_List[0].CO_CompanyEmail.ToString();
            tb_CompanyName.Text = CO_List[0].CO_CompanyName.ToString();
            tb_CompanyContact.Text = CO_List[0].CO_CompanyContact.ToString();
            tb_CompanyAddress.Text = CO_List[0].CO_CompanyAddress.ToString();


            // =============== Gridview =================

            DAL_OrderItem item = new DAL_OrderItem();
            DataTable ds;
            ds = item.GetAll_OrderItem();
            gv_OrderItem.DataSource = ds;
            gv_OrderItem.DataBind();


            gv_OrderItem.FooterRow.Cells[2].Text = "Total Amount";
            gv_OrderItem.FooterRow.Cells[3].Text = ds.Compute("SUM(OI_Price)", "").ToString();


            lbl_To.Text = CO_List[0].CO_CompanyEmail.ToString();

        }

        protected void btn_send_Click(object sender, EventArgs e)
        {

            string to, from;
            string CO_ID = Request.QueryString["CO_ID"];
            List<DAL_CustomerOrder> CO_List = new List<DAL_CustomerOrder>();
            CO_List = obj.GetSingleCustomerOrder(CO_ID);
            to = CO_List[0].CO_CompanyEmail.ToString();
            from = "votech.eap@gmail.com";

            MailMessage message = new MailMessage(from, to, tb_subject.Text, tb_body.Text);
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("votech.eap@gmail.com", "votechvotech");
            client.Send(message);

            //Response.Write("<script>alert('Email successfully sent!');</script>");

            ClientScript.RegisterStartupScript(this.GetType(), "randomtext", "alertMe2()", true);

        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerOrder.aspx");
        }

        protected void btn_Summary_Click(object sender, EventArgs e)
        {
            string CO_ID = Request.QueryString["CO_ID"];

            //Response.Redirect("~/Web/Admin/CustomerOrder_Summary.aspx?CO_ID=" + CO_ID);

            Response.Write("<script>window.open ('CustomerOrder_Summary.aspx?CO_ID=" + CO_ID + "','_blank');</script>");


        }

        protected void gv_OrderItem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newPageIndex = e.NewPageIndex;
            gv_OrderItem.PageIndex = newPageIndex;
            bind();
        }
    }
}