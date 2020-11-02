using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using EAP_Company_FixTech.DAL.Lester;

namespace EAP_Company_FixTech.BLL.Lester
{
    public class BLL_Payment
    {
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            DAL_Payment dataLayerPS;

            dataLayerPS = new DAL_Payment();
            return dataLayerPS.PaySupplier(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }
    }
}