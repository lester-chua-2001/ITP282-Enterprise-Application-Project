using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EAP_Company_FixTech.DAL.Tjandra;

namespace EAP_Company_FixTech.BLL.Tjandra
{
    public class BLL_OrderItem
    {
        public int createOrderItems(string ProdName, string ProdDesc, string ProdPrice)
        {
            DAL_OrderItem obj = new DAL_OrderItem();
            return obj.createOrderItems(ProdName, ProdDesc, ProdPrice);
        }

        public int insertOrderItem(string ProdName, string ProdDesc, string ProdPrice)
        {
            DAL_OrderItem obj = new DAL_OrderItem();
            return obj.insertOrderItem(ProdName, ProdDesc, ProdPrice);
        }
    }
}