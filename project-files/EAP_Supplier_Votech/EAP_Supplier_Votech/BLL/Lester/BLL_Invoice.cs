using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.BLL.Lester
{
    public class BLL_Invoice
    {
        public DataSet GetAllInvoice()
        {
            DAL_SendingInvoice dataLayerPS;

            dataLayerPS = new DAL_SendingInvoice();
            return dataLayerPS.GetAllInvoice();
        }
        public List<DAL_CreateInvoice> GetInvoiceCreated()
        {
            DAL_CreateInvoice dataLayerPS;
            dataLayerPS = new DAL_CreateInvoice();
            return dataLayerPS.GetInvoiceCreated();
        }
        public DataSet getallInvoiceOrderItem()
        {
            DAL_InvoiceOrderItem dataLayerPS;
            dataLayerPS = new DAL_InvoiceOrderItem();
            return dataLayerPS.GetAllInvoiceOrderItem();
        }
    }
}