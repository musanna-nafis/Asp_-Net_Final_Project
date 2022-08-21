using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.FinanceManager
{
   public  interface IPaymentHistory<CLASS, ID>
    {
        List<CLASS> Gethistory(ID id);
    }
}
