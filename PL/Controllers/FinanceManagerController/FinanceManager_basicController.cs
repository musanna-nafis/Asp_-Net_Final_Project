using BLL.Entities;
using BLL.Services.FinanceManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL.Controllers.FinanceManagerController
{
    class FinanceManager_basicController : ApiController
    {
        [Route("api/FinanceManager/Home/{id}")]
        [HttpGet]
        public HttpResponseMessage Home(int id)
        {
            var data = FinanceManagerBasicService.GetHomePage(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        //Leave Request

        [Route("api/Finance/Requests/{id}")]
        [HttpGet]
        public HttpResponseMessage Leave(int id)
        {
            var data = FinanceManagerBasicService.LeaveRequest(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/FinanceManager/LeaveRequests/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage LeaveDelete(int id)
        {
            var data = FinanceManagerBasicService.LeaveRequestDelete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/FinanceManager/LeaveRequests/new/{id}")]
        [HttpPost]
        public HttpResponseMessage CreateLeave(int id,LeaveRequestModel l)
        {
            var data = FinanceManagerBasicService.LeaveRequestCreate(id,l);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
