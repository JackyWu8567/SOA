using SoaIntroNet.Service;
using SoaIntroNet.Service.Requests;
using SoaIntroNet.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoaIntroNet.WebProxy.Controllers
{
    public class PurchaseController : ApiController
    {
        private readonly IProductService _productService;

        public PurchaseController(IProductService productService)
        {
            if (productService == null) throw new ArgumentNullException("IProductService");
            _productService = productService;
        }

        [HttpPost]
        public HttpResponseMessage Post(PurchaseProductRequest purchaseProductRequest)
        {
            purchaseProductRequest.CorrelationId = purchaseProductRequest.ReservationId;
            ServiceResponseBase response = _productService.PurchaseProduct(purchaseProductRequest);
            return Request.BuildResponse(response);
        }
    }
}
