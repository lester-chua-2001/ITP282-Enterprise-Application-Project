using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EAP_Company_FixTech.DAL.Lester;

namespace EAP_Company_FixTech.Web.Admin
{
    public partial class PayingToSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tb_InvoiceNum.Text = Request.QueryString["InvoiceNum"].ToString();
        }

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfSupplierInvoice.aspx");
        }

        protected void btn_Pay_Click(object sender, EventArgs e)
        {
            DAL_Access_Supplier_Votech obj = new DAL_Access_Supplier_Votech();
            //insert into local DB
            obj.companyPaySupplier(tb_PaymentDate.Text,tb_ChequeNo.Text, Convert.ToInt32(tb_PaymentAmount.Text), tb_Payee.Text, tb_Memo.Text, Convert.ToInt32(tb_InvoiceNum.Text));
            Response.Write("<script>alert('Successfully Paid!');</script>");

            //insert into supplier DB
            obj.PaySupplier(tb_PaymentDate.Text,tb_ChequeNo.Text, Convert.ToInt32(tb_PaymentAmount.Text), tb_Payee.Text, tb_Memo.Text, Convert.ToInt32(tb_InvoiceNum.Text));
        }

        protected void CalPaymentDate_SelectionChanged(object sender, EventArgs e)
        {
            tb_PaymentDate.Text = CalPaymentDate.SelectedDate.ToString("dd/MM/yyyy");
        }

        protected void CalPaymentDate_DayRender(object sender, DayRenderEventArgs e)
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