using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaIntroNet.Service.Requests
{
    public class ReserveProductRequest
    {
        public string ProductId { get; set; }
        public int ProductQuantity { get; set; }
    }

}
