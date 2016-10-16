using oms_test_framework_dotNET.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oms_test_framework_dotNET.Repository.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);

        int CreateProduct(Product product);

        void DeleteProduct(int productId);
    }
}
