using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vinfast.models;
using Microsoft.AspNetCore.Components;

namespace Vinfast.web.Services
{
    public class ProduceService : IProduceService
    {
        private readonly HttpClient httpClient;
        public ProduceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await httpClient.GetJsonAsync<Product[]>("api/product");
        }
        public async Task<Product> GetProduct(int id)
        {
            return await httpClient.GetJsonAsync<Product>($"api/product/{id}");
        }
        public async Task<Product> UpdateProduct(Product updatedProduct)
        {
            return await httpClient.PutJsonAsync<Product>("api/product", updatedProduct);
        }
        public async Task<Product> CreateProduct(Product newProduct)
        {
            return await httpClient.PostJsonAsync<Product>("api/product", newProduct);
        }

        public async Task DeleteProduct(int id)
        {
            await httpClient.DeleteAsync($"api/product/{id}");
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await httpClient.GetJsonAsync<Product>($"api/product/{name}");
        }
    }
}
