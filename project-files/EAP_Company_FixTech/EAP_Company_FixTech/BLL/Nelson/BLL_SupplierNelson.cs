using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EAP_Company_FixTech.DAL.Nelson;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;

namespace EAP_Company_FixTech.BLL.Nelson
{
    public class BLL_SupplierNelson
    {
        DAL_SupplierNelson obj = new DAL_SupplierNelson();
        public DataSet getAllDeliveryOrders()
        {
            return obj.getAllDeliveryOrders();
        }

        public DAL_DeliveryOrder[] getDeliveryOrder(string DO_ID)
        {
            DAL_DeliveryOrder[] getDeliveryOrder;
            getDeliveryOrder = obj.getDeliveryOrder(DO_ID);
            return getDeliveryOrder;
        }
    }
}