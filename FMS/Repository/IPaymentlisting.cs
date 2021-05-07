using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FMS.Models;

namespace FMS.Repository
{
    interface IPaymentlisting
    {
        IEnumerable<PaymentlistingDTO> AllPaymentDetails(string MemberID);
        IEnumerable<PaymentlistingDTO> AllPaymentDetails();
        IEnumerable<PaymentAutocompDTO> ListofMemberNo(string Memberno);
        IEnumerable<PaymentAutocompDTO> ListofMemberName(string Membername);
    }
}
