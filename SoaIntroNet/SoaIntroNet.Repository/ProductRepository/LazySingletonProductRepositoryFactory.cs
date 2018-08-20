using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaIntroNet.Repository.ProductRepository
{
    public class LazySingletonProductRepositoryFactory : IProductRepositoryFactory
    {
        public InMemoryProductRepository Create()
        {
            return InMemoryProductRepository.Instance;
        }
    }
}
