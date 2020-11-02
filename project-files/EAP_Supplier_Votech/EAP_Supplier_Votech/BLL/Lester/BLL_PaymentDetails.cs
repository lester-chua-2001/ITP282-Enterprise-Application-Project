using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAP_Supplier_Votech.DAL.Lester;

namespace EAP_Supplier_Votech.BLL.Lester
{
    public class BLL_PaymentDetails
    {
        public int PaySupplier(string PaymentDate, string ChequeNo, decimal PaymentAmount, string Payee, string Memo, int InvoiceNum)
        {
            DAL_PaymentDetails obj = new DAL_PaymentDetails();
            return obj.PaySupplier(PaymentDate, ChequeNo, PaymentAmount, Payee, Memo, InvoiceNum);
        }
    }
}