using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using EAP_Company_FixTech.DAL.Tjandra;

namespace EAP_Company_FixTech.BLL.Tjandra
{
    public class BLL_Inventory
    {
        public DataSet GetAll_Inventory()
        {
            DAL_Inventory dal;
            DataSet inventoryList;

            dal = new DAL_Inventory();
            inventoryList = dal.GetAll_Inventory();

            return inventoryList;
        }

    }
}