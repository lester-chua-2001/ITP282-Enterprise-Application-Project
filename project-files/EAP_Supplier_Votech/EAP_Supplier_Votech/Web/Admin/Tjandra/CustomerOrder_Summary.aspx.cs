using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EAP_Supplier_Votech.DAL.Tjandra;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Diagnostics;
using System.IO;

namespace EAP_Supplier_Votech.Web.Admin
{
    public partial class PurchaseOrder_Summary : System.Web.UI.Page
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

            lbl_ID.Text = CO_ID;
            lbl_Email.Text = CO_List[0].CO_CompanyEmail.ToString();
            lbl_Name.Text = CO_List[0].CO_CompanyName.ToString();
            lbl_contact.Text = CO_List[0].CO_CompanyContact.ToString();
            lbl_Address.Text = CO_List[0].CO_CompanyAddress.ToString();
            lbl_Date.Text = CO_List[0].CO_Date.ToString();


            // =============== Gridview =================

            DAL_OrderItem item = new DAL_OrderItem();
            DataTable ds;
            ds = item.GetAll_OrderItem();
            gv_OrderItem.DataSource = ds;
            gv_OrderItem.DataBind();


            gv_OrderItem.FooterRow.Cells[2].Text = "Total Amount";
            gv_OrderItem.FooterRow.Cells[3].Text = ds.Compute("SUM(OI_Price)", "").ToString();

            lbl_Total.Text = ds.Compute("SUM(OI_Price)", "").ToString();
        }

        //protected void btn_Export_Click(object sender, EventArgs e)
        //{
        //    PdfPTable pdfTable = new PdfPTable(gv_OrderItem.HeaderRow.Cells.Count);

        //    foreach (GridViewRow row in gv_OrderItem.Rows)
        //    {
        //        foreach (TableCell cell in row.Cells)
        //        {
        //            PdfPCell pdCell = new PdfPCell(new Phrase(cell.Text));
        //            pdfTable.AddCell(pdCell);
        //        }
        //    }

        //    Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
        //    PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

        //    pdfDocument.Open();
        //    pdfDocument.Add(pdfTable);

        //    pdfDocument.Close();

        //    // TO open file
        //    Response.ContentType = "application/pdf";
        //    Response.AppendHeader("content-disposition", "attachement;filename=OrderItems.pdf");
        //    Response.Write(pdfDocument);
        //    Response.Flush();
        //    Response.End();

        //}
    }
}