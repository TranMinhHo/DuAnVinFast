using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vinfast.models;
using Vinfast.web.Services;
namespace Vinfast.web.Pages
{
    public class DisplayProductBase : ComponentBase
    {
        [Parameter]
        public Product Product { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
        protected bool IsSelected { get; set; }

        [Parameter]
        public EventCallback<bool> OnProductSelection { get; set; }

        [Parameter]
        public EventCallback<int> OnProductDeleted { get; set; }

        [Inject]
        public IProduceService ProduceService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected Mh.Components.ConfirmBase DeleteConfirmation { get; set; }    
        public void Delete_Click()
        {
            DeleteConfirmation.Show();
        }
        protected async Task ConfirmDelete_Click(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await ProduceService.DeleteProduct(Product.ProductId);
                await OnProductDeleted.InvokeAsync(Product.ProductId);
            }
        }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnProductSelection.InvokeAsync(IsSelected);
        }
    }
}
