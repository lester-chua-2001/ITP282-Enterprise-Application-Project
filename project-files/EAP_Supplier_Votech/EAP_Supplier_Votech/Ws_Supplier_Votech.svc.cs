using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using EAP_Supplier_Votech.BLL.Tjandra;
using EAP_Supplier_Votech.BLL.Lester;
using EAP_Supplier_Votech.BLL.Nelson;
using EAP_Supplier_Votech.DAL.Nelson;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Ws_Supplier_Votech" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Ws_Supplier_Votech.svc or Ws_Supplier_Votech.svc.cs at the Solution Explorer and start debugging.
    public class Ws_Supplier_Votech : IWs_Supplier_Votech
    {
        //Tjandra
       public int insertPurchaseOrder(string name, string email, string contact, string address, string date)
        {
            BLL_Supplier_Class bizLayerInsertPO = new BLL_Supplier_Class();
            return bizLayerInsertPO.insertPurchaseOrder(name, email, contact, address, date);
        }

        public int createOrderItems(string ProdName, string ProdDesc, string ProdPrice)
        {
            BLL_Supplier_Class bizLayerCreate = new BLL_Supplier_Class();
            return bizLayerCreate.createOrderItems(ProdName, ProdDesc, ProdPrice);
        }

        public DataSet GetAll_Inventory()
        {
            BLL_Supplier_Class obj = new BLL_Supplier_Class();
            return obj.GetAll_Inventory();
        }

        //Lester
        public DataSet GetAllCustomerOrders()
        {
            BLL_Payment dataLayerPS = new BLL_Payment();
            return dataLayerPS.GetAllCustomerOrders();
        }
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            BLL_PaymentDetails obj = new BLL_PaymentDetails();
            return obj.PaySupplier(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }
        public List<DAL_CreateInvoice> GetInvoiceCreated()
        {
            BLL_Invoice obj = new BLL_Invoice();
            return obj.GetInvoiceCreated();
        }
        public DataSet getallInvoiceOrderItem()
        {
            BLL_Invoice obj = new BLL_Invoice();
            return obj.getallInvoiceOrderItem();
        }


        //Nelson
        public List<DAL_DeliveryOrder> getDeliveryOrder(string DO_ID)
        {
            BLL_SupplierNelson bizLayergetDO = new BLL_SupplierNelson();
            return bizLayergetDO.getDeliveryOrder(DO_ID);
        }

        public DataSet getAllDeliveryOrders()
        {
            BLL_SupplierNelson bizLayergetDO = new BLL_SupplierNelson();
            return bizLayergetDO.getAllDeliveryOrders();
        }


    }
}
