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
    public class PaymentRepo : IRepo<Finance_payment_histories, int, bool> , IPaymentHistory<Finance_payment_histories, int> , IInvoice<Invoice, int>
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

        public bool CustomerAdjust(int id, int id1)
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

        public List<Invoice> GetCustomer(int id)
        {
            var invoice = (from e in db.Invoices
                           where e.manager_id == id && e.type.Equals("Customer") && e.status.Equals("Unadjusted")
                           select e).ToList();
            return invoice;
        }

        public List<Finance_payment_histories> Gethistory(int id)
        {
            var history = (from e in db.Finance_payment_histories
                            where e.manager_id == id
                            select e).ToList();
            return history;
        }

        public List<Invoice> GetSupplier(int id)
        {
            var invoice = (from e in db.Invoices
                           where e.manager_id == id && e.type.Equals("Supplier") && e.status.Equals("Unadjusted")
                           select e).ToList();
            return invoice;
        }

        public bool SupplierAdjust(int id, int id1)
        {
            throw new NotImplementedException();
        }

        public bool Update(Finance_payment_histories obj)
        {
            throw new NotImplementedException();
        }
    }
}
