using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAP_Supplier_Votech.DAL.Lester;
using System.Data;

namespace EAP_Supplier_Votech.BLL.Lester
{
    public class BLL_CreateInvoice
    {
        public int createinvoice(string InvoiceDate, decimal InvoiceTotalAmt, int CO_ID)
        {
            DAL_CreateInvoice obj = new DAL_CreateInvoice();
            return obj.createinvoice(InvoiceDate, InvoiceTotalAmt, CO_ID);
        }
    }
}