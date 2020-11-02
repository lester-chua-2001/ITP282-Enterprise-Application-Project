using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EAP_Company_FixTech.Supplier_Votech_ServiceReference;


namespace EAP_Company_FixTech.DAL.Nelson
{
    public class DAL_SupplierNelson
    {
        Ws_Supplier_VotechClient VotechClient = new Ws_Supplier_VotechClient();
        public DataSet getAllDeliveryOrders()
        {
            return VotechClient.getAllDeliveryOrders();
        }
        public DAL_DeliveryOrder[] getDeliveryOrder(string DO_ID)
        {
            return VotechClient.getDeliveryOrder(DO_ID);
        }
    }
}