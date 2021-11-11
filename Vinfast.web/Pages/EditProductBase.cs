using AutoMapper;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vinfast.models;
using Vinfast.web.Services;

namespace Vinfast.web.Pages
{
    public class EditProductBase :ComponentBase
    {
        [Inject]
        public IProduceService ProduceService { get; set; }
        private Product Product { get; set; } = new Product();
        public EditProductModel EditProductModel { get; set; } = new EditProductModel();
       
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int productId);

            if(productId !=0)
            {
                Product = await ProduceService.GetProduct(int.Parse(Id));
            }
            else
            {
                Product = new Product
                {
                    PhotoPath = "/image/nophoto.png"
                };
                
            }

           Mapper.Map(Product, EditProductModel);

            //EditProductModel.ProductId = Product.ProductId;
            //EditProductModel.Name = Product.Name;
            //EditProductModel.Price = Product.Price;
            //EditProductModel.PriceDisplay = Product.PriceDisplay;
            //EditProductModel.version = Product.version;
            //EditProductModel.PhotoPath = Product.PhotoPath;
            
            
        }
        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditProductModel, Product);
            Product result = null;

            if(Product.ProductId != 0)
            {
               result = await ProduceService.UpdateProduct(Product);
            }
            else
            {
                result = await ProduceService.CreateProduct(Product);
            }

         

            if(result!=null)
            {
                NavigationManager.NavigateTo("https://localhost:44303/allproduct");
            }
        }
        protected async Task Delete_Click()
        {
            await ProduceService.DeleteProduct(Product.ProductId);
            NavigationManager.NavigateTo("https://localhost:44303/allproduct");

        }
    }
}
