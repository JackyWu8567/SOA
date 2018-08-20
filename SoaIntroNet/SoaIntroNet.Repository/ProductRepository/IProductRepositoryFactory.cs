using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaIntroNet.Repository.ProductRepository
{
    public interface IProductRepositoryFactory
    {
        InMemoryProductRepository Create();
    }
}
