using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.Web.Admin.Lester
{
    public partial class CreateInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tb_COID.Text = Request.QueryString["CO_ID"].ToString();
        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendingInvoice.aspx");
        }

        protected void btn_CreateInvoice_Click(object sender, EventArgs e)
        {
            //Sending email
            string to, from, subject, body;
            to = "fixtech.eap@gmail.com";
            from = "votech.eap@gmail.com";
            subject = "[Auto Generated Email] Invoice is Ready to View";
            body = "Dear customer, Your Invoice is ready for viewing. Thank You and Please Pay as soon as possible";

            MailMessage message = new MailMessage(from, to, subject, body);
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("votech.eap@gmail.com", "votechvotech");
            client.Send(message);


            DAL_CreateInvoice obj = new DAL_CreateInvoice();
            //Insert into Invoice
            obj.createinvoice(tb_CreationDate.Text, Convert.ToInt32(tb_InvoiceTotalAmt.Text), Convert.ToInt32(tb_COID.Text));
            Response.Write("<script>alert('Successfully Created Invoice!');</script>");
            Response.Redirect("InvoiceCreated.aspx");


        }

        protected void CalCreationDate_SelectionChanged(object sender, EventArgs e)
        {
            tb_CreationDate.Text = CalCreationDate.SelectedDate.ToString("dd/MM/yyyy");
        }

        protected void CalCreationDate_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime pastday = e.Day.Date;
            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            DateTime today = new DateTime(year, month, day);
            if (pastday.CompareTo(today) < 0)
            {
                e.Cell.BackColor = System.Drawing.Color.Gray;
                e.Day.IsSelectable = false;
            }
        }
    }
}