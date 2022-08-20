using BLL.Entities;
using BLL.Services.ProductManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL.Controllers.ProductManagerController
{
    public class ProductController : ApiController
    {
        [Route("api/products")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = ProductServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        
        [Route("api/product/create")]
        [HttpPost]
        public HttpResponseMessage Create(ProductModel product)
        {
            var data = ProductServices.Create(product);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/product/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = ProductServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/product/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = ProductServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/product/update")]
        [HttpPost]
        public HttpResponseMessage Update(ProductModel product)
        {
            var data = ProductServices.Update(product);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        
        [Route("api/product/ChartData")]
        [HttpPost]
        public HttpResponseMessage ChartData()
        {
            var data = ProductServices.GetChartData();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
