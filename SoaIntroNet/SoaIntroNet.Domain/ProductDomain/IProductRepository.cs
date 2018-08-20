using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaIntroNet.Domain.ProductDomain
{
    public interface IProductRepository
    {
        Product FindBy(Guid productId);
        void Save(Product product);
    }
}
