using BLL.Services.FinanceManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL.Controllers.FinanceManagerController
{
    public class FinanceManager_ProfessionalController : ApiController
    {
        [Route("api/financemanager/paymenthistory/{id}")]
        [HttpGet]
        public HttpResponseMessage Payment(int id)
        {
            var data = FinanceManagerProfessionalService.paymenthistory(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/financemanager/customerpayment/{id}")]
        [HttpGet]
        public HttpResponseMessage CustomerPayment(int id)
        {
            var data = FinanceManagerProfessionalService.customerpayment(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/financemanager/supplierpayment/{id}")]
        [HttpGet]
        public HttpResponseMessage SupplierPayment(int id)
        {
            var data = FinanceManagerProfessionalService.supplierpayment(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
