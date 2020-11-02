using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.BLL.Lester
{
    public class BLL_Payment
    {
        public DataSet GetAllCustomerOrders()
        {
            DAL_PaymentStatus dataLayerPS;

            dataLayerPS = new DAL_PaymentStatus();
            return dataLayerPS.GetAllCustomerOrders();
        }

        public int PaymentStatusUpdate(string CO_ID, string CO_PaymentStatus)
        {
            DAL_PaymentStatus obj = new DAL_PaymentStatus();
            return obj.PaymentStatusUpdate(CO_ID, CO_PaymentStatus);
        }
    }
}