using BLL.Entities;
using DAL.DataAccessFactory;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.FinanceManagerServices
{
    public class FinanceManagerBasicService
    {
        public static List<object> GetHomePage(int id)
        {
             return null;
        }

        public static List<LeaveRequestModel> LeaveRequest(int id)
        {
            var data = DataAccessFactory.FinanceManagerLeaveDataAccess().GetLeave(id);
            var leaverequests = new List<LeaveRequestModel>();
            foreach (var item in data)
            {
                leaverequests.Add(new LeaveRequestModel()
                {
                    id = item.id,
                    type = item.type,
                    request_description = item.request_description,
                    start_time = item.start_time,
                    end_time = item.end_time,
                    request_made = item.request_made,
                    status = item.status,
                    employee_id = item.employee_id,
                });
            }
            return leaverequests;
        }

        public static bool LeaveRequestDelete(int id)
        {
            return DataAccessFactory.FinanceManagerLeave1DataAccess().Delete(id);
        }

        public static bool LeaveRequestCreate(int id,LeaveRequestModel leave)
        {
            var myleave = new Leave_requests()
            {
                type = leave.type,
                request_description = leave.request_description,
                start_time = leave.start_time,
                end_time = leave.end_time,
                request_made = DateTime.Today,
                status = "pending",
                employee_id = id,
            };
            return DataAccessFactory.FinanceManagerLeave1DataAccess().Create(myleave);
        }
    }
}
