using DAL.EF;
using DAL.Interfaces.Common;
using DAL.Interfaces.FinanceManager;
using DAL.Interfaces.ProductManager;
using DAL.Repo.FinanceManagerRepo;
using DAL.Repo.ProductManagerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccessFactory
{
    public class DataAccessFactory
    {
        static ERPEntities db = new ERPEntities();

        //FinanceManager
        public static ILeave_request<Leave_requests,int> FinanceManagerLeaveDataAccess()
        {
            return new LeaveRequestRepo(db);
        }

        public static IRepo<Leave_requests, int, bool> FinanceManagerLeave1DataAccess()
        {
            return new LeaveRequestRepo(db);
        }

        public static IRepo<User, int, bool> FinanceManagerProfileDataAccess()
        {
            return new ProfileRepo(db);
        }

        public static IProfile<User, int, string> FinanceManagerProfile1DataAccess()
        {
            return new ProfileRepo(db);
        }
        public static IPass<FinanceManagerPass, int, string> FinanceManagerProfile2DataAccess()
        {
            return new ProfileRepo(db);
        }

        public static IPaymentHistory<Finance_payment_histories, int> FinanceManagerPaymentDataAccess()
        {
            return new PaymentRepo(db);
        }
        public static IInvoice<Invoice, int> FinanceManagerInvoiceDataAccess()
        {
            return new PaymentRepo(db);
        }

        public static IEmail<FinanceManager_Email, string> FinanceManagerEmailDataAccess()
        {
            return new EmailSendRepo(db);
        }

        public static IBank<Bank, int, bool> FinanceManagerBankworkDataAccess()
        {
            return new BudgetingRepo(db);
        }

        ///end
        public static IRepo<Product, int, bool> ProductDataAccess()
        {
            return new ProductRepo(db);
        }

        public static IRepo<Warehouse, int, bool> WareHouseDataAccess()
        {
            return new WareHouseRepo(db);
        }
        

       public static IWarehouse<Warehouse, string> WareHouseDataAccessName()
        {
            return new WareHouseRepo(db);
        }

        public static IRepo<Issue, int, bool> ProductManagerIssueDataAccess()
        {
            return new IssueRepo(db);
        }

        
    }
}
