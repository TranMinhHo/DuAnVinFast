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

            Product = await ProduceService.GetProduct(int.Parse(Id));

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
            var result = await ProduceService.UpdateProduct(Product);

            if(result!=null)
            {
                NavigationManager.NavigateTo("https://localhost:44303/allproduct");
            }
        }
    }
}
