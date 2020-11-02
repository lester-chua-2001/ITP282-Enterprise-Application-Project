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
    public partial class PurchaseOrder_ViewMore : System.Web.UI.Page
    {

        DAL_PurchaseOrder obj = new DAL_PurchaseOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void bind()
        {
            string PO_ID = Request.QueryString["PO_ID"];
            List<DAL_PurchaseOrder> PO_List = new List<DAL_PurchaseOrder>();
            PO_List = obj.GetSinglePurchaseOrders(PO_ID);

            tb_PO_ID.Text = PO_ID;
            tb_PO_CompanyEmail.Text = PO_List[0].PO_CompanyEmail.ToString();
            tb_CompanyName.Text = PO_List[0].PO_CompanyName.ToString();
            tb_CompanyContact.Text = PO_List[0].PO_CompanyContact.ToString();
            tb_CompanyAddress.Text = PO_List[0].PO_CompanyAddress.ToString();

            lbl_To.Text = PO_List[0].PO_CompanyEmail.ToString();


            // =============== Gridview =================

            DAL_OrderItem item = new DAL_OrderItem();
            DataTable ds;
            ds = item.GetAll_OrderItem();
            gv_OrderItem.DataSource = ds;
            gv_OrderItem.DataBind();

            gv_OrderItem.FooterRow.Cells[2].Text = "Total Amount";
            gv_OrderItem.FooterRow.Cells[3].Text = ds.Compute("SUM(OI_Price)", "").ToString();


        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("PurchaseOrder.aspx");
        }


        protected void btn_send_Click(object sender, EventArgs e)
        {

            string to, from;
            string PO_ID = Request.QueryString["PO_ID"];
            List<DAL_PurchaseOrder> PO_List = new List<DAL_PurchaseOrder>();
            PO_List = obj.GetSinglePurchaseOrders(PO_ID);
            to = PO_List[0].PO_CompanyEmail.ToString();
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

        protected void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            string PO_ID = Request.QueryString["PO_ID"];

            List<DAL_PurchaseOrder> PO_List = new List<DAL_PurchaseOrder>();
            PO_List = obj.GetSinglePurchaseOrders(PO_ID);
            string PO_CompanyName = PO_List[0].PO_CompanyName.ToString();
            string PO_companyEmail = PO_List[0].PO_CompanyEmail.ToString();
            string PO_CompanyContact = PO_List[0].PO_CompanyContact.ToString();
            string PO_CompanyAddress = PO_List[0].PO_CompanyAddress.ToString();
            string PO_Date = PO_List[0].PO_Date.ToString();
            string OI_ID = PO_List[0].OI_ID.ToString();
            string ProdId = PO_List[0].ProdID.ToString();

            obj.createCustomerOrder(PO_ID, PO_CompanyName, PO_companyEmail, PO_CompanyContact, PO_CompanyAddress, PO_Date, OI_ID, ProdId);

            obj.acceptPurchaseOrderStatus(Convert.ToInt32(PO_ID));


            // ============== Email ================
            //string PO_ID = PO_List[0].PO_ID.ToString();

            string to, from, subject, body;
            to = PO_List[0].PO_CompanyEmail.ToString();
            from = "votech.eap@gmail.com";
            subject = "[Auto Generated Email] Order Placed!";
            body = "Order Number : " + PO_ID + "<br> Dear customer, thank you for shopping with us. Please contact us at (+65) 6874 5852 for enquiries.";

            MailMessage message = new MailMessage(from, to, subject, body);
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("votech.eap@gmail.com", "votechvotech");
            client.Send(message);


            //Response.Write("<script>alert('Order has been created successfully!');</script>");

            ClientScript.RegisterStartupScript(this.GetType(), "randomtext", "alertMe()", true);


        }

        protected void gv_OrderItem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int newPageIndex = e.NewPageIndex;
            gv_OrderItem.PageIndex = newPageIndex;
            bind();
        }
    }
}