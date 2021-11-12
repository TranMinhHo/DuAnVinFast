using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vinfast.models;
using Vinfast.web.Services;


namespace Vinfast.web.Pages
{
    public class ProductListBase : ComponentBase
    {
        public string Ten { get; set; }
        public string Datcoc { get; set; }
        public string ImageOnClick1 { get; set; }
        [Inject]
        public IProduceService ProduceService { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public bool ShowFooter { get; set; } = true;
        
        protected override async Task OnInitializedAsync()
        {
            Products = (await ProduceService.GetProducts()).ToList();
        }
        
        protected async Task ProductDeleted()
        {
            Products = (await ProduceService.GetProducts()).ToList();
        }

        protected int SelectedProductCount { get; set; } = 0;

        protected void ProductSelectionChange(bool isSelected)
        {
            if (isSelected)
            {
                SelectedProductCount++;
            }
            else
            {
                SelectedProductCount--;
            }
        }
      
        public async Task Img_Fadil()
        {
            Products = (await ProduceService.GetProducts()).ToList();
            ImageOnClick1 = "/image/fadil360.png";
            Datcoc = "30.000.000";
            Ten = "FADIL";
             
        }
        public async Task Img_Sa()
        {
            Products = (await ProduceService.GetProducts()).ToList();
            ImageOnClick1 = "/image/sa360.png";
            Datcoc = "50.000.000";
            Ten = "SA2.0";
        }
        public async Task Img_President()
        {
            Products = (await ProduceService.GetProducts()).ToList();
            ImageOnClick1 = "/image/president360.png";
            Datcoc = "100.000.000";
            Ten = "PRESIDENT";
        }
        public async Task Img_A20()
        {
            Products = (await ProduceService.GetProducts()).ToList();
            ImageOnClick1 = "/image/a360.png";
            Datcoc = "50.000.000";
            Ten = "A20";
        }
    }
 }

