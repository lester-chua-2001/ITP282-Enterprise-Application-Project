using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAP_Company_FixTech.DAL.Lester;
using System.Data;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;

namespace EAP_Company_FixTech.BLL.Lester
{
    public class BLL_Supplier_Votech
    {
        DAL_Access_Supplier_Votech obj = new DAL_Access_Supplier_Votech();
        public DataSet GetAllCustomerOrders()
        {
            DAL_Access_Supplier_Votech dataLayerPS;
            DataSet datasetCustomerOrders;

            dataLayerPS = new DAL_Access_Supplier_Votech();
            datasetCustomerOrders = dataLayerPS.GetAllCustomerOrders();
            return datasetCustomerOrders;
        }

        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            DAL_Access_Supplier_Votech obj = new DAL_Access_Supplier_Votech();
            return obj.PaySupplier(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }
        public DAL_CreateInvoice[] GetInvoiceCreated()
        {
            DAL_CreateInvoice[] getinvoicecreated;
            getinvoicecreated = obj.GetInvoiceCreated();
            return getinvoicecreated;
        }
        public DataSet getInvoiceOrderItem()
        {
            DAL_Access_Supplier_Votech dataLayerPS;
            DataSet datasetgetinvoiceorderitem;

            dataLayerPS = new DAL_Access_Supplier_Votech();
            datasetgetinvoiceorderitem = dataLayerPS.getInvoiceOrderItem();
            return datasetgetinvoiceorderitem;
        }
    }
}