using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.BLL.Lester
{
    public class BLL_InvoiceViewMore
    {
        public DataSet getInvoiceViewMore()
        {
            DAL_InvoiceViewDetails dataLayerPS;

            dataLayerPS = new DAL_InvoiceViewDetails();
            return dataLayerPS.getInvoiceViewMore();
        }
    }
}