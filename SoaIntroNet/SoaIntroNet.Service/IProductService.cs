using SoaIntroNet.Service.Requests;
using SoaIntroNet.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaIntroNet.Service
{
    public interface IProductService
    {
        ProductReservationResponse ReserveProduct(ReserveProductRequest productReservationRequest);
        PurchaseProductResponse PurchaseProduct(PurchaseProductRequest productPurchaseRequest);
    }
}
