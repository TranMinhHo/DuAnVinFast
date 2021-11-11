using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vinfast.models;

namespace Vinfast.web.Services
{
    public interface IProduceService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Product> UpdateProduct(Product updatedProduct);
        Task<Product> CreateProduct(Product newProduct);
        Task DeleteProduct(int id);
        Task<Product> GetProductByName(string name);
    }
}
