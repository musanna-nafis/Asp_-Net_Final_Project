using DAL.EF;
using DAL.Interfaces.Common;
using DAL.Interfaces.FinanceManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.FinanceManagerRepo
{
    public class PaymentRepo : IRepo<Finance_payment_histories, int, bool> , IPaymentHistory<Finance_payment_histories, int>
    {
        private ERPEntities db;

        public PaymentRepo(ERPEntities db)
        {
            this.db = db;
        }
        public bool Create(Finance_payment_histories obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Finance_payment_histories> Get()
        {
            throw new NotImplementedException();
        }

        public Finance_payment_histories Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Finance_payment_histories> Gethistory(int id)
        {
            var history = (from e in db.Finance_payment_histories
                            where e.manager_id == id
                            select e).ToList();
            return history;
        }

        public bool Update(Finance_payment_histories obj)
        {
            throw new NotImplementedException();
        }
    }
}
