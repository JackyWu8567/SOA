﻿using SoaIntroNet.Service;
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
    public class ReservationController : ApiController
    {
        private readonly IProductService _productService;

        public ReservationController(IProductService productService)
        {
            if (productService == null) throw new ArgumentNullException("IProductService");
            _productService = productService;
        }

        [HttpPost]
        public HttpResponseMessage Post(ReserveProductRequest reserveProductRequest)
        {
            ServiceResponseBase response = _productService.ReserveProduct(reserveProductRequest);
            return Request.BuildResponse(response);
        }
    }
}
