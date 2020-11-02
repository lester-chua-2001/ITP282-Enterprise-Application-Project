using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EAP_Supplier_Votech.DAL.Nelson;


namespace EAP_Supplier_Votech.BLL.Nelson
{
    public class BLL_SupplierNelson
    {
        public DataSet getAllDeliveryOrders()
        {
            DAL_DeliveryOrder DO = new DAL_DeliveryOrder();
            return DO.getAllDeliveryOrders();
        }

        public List<DAL_DeliveryOrder> getDeliveryOrder(string DO_ID)
        {
            DAL_DeliveryOrder DO = new DAL_DeliveryOrder();
            return DO.getDeliveryOrder(DO_ID);
        }
    }
}