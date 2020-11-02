using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EAP_Company_FixTech.Supplier_Votech_ServiceReference;
using System.Data;

namespace EAP_Company_FixTech.DAL.Tjandra
{
    public class DAL_Inventory
    {
        public DataSet GetAll_Inventory()
        {
            Ws_Supplier_VotechClient client;
            client = new Ws_Supplier_VotechClient();
            return client.GetAll_Inventory();
        }

    }
}