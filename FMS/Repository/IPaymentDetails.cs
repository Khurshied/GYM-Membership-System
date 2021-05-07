using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FMS.Models;

namespace FMS.Repository
{
    interface IPaymentDetails
    {
        int InsertPaymentDetails(PaymentDetailsDTO objPD);
        int UpdatePaymentDetails(PaymentDetailsDTO objPD);
    }
}
