using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex17.Services
{
    public interface IOnlinePaymentService
    {
       public double PaymentFee (double amount);
       double Interest(double amount, int months);
    }
}