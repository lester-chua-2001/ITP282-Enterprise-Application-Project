using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using EAP_Company_FixTech.DAL.Tjandra;

namespace EAP_Company_FixTech.BLL.Tjandra
{
    public class BLL_PurchaseOrder
    {
        public int insertPurchaseOrder(string name, string email, string contact, string address, string date)
        {
            DAL_PurchaseOrder obj = new DAL_PurchaseOrder();
            return obj.insertPurchaseOrder(name, email, contact, address, date);
        }

        public int insertOrderItems(string date)
        {
            DAL_PurchaseOrder obj = new DAL_PurchaseOrder();
            return obj.insertOrderItems(date);
        }

    }
}