using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.Services
{
    public interface ISaleService
    {
        event Action OnChange;
        Task AddToCart(List<CreateSaleInputModel> item);
    }
    public class SaleService : ISaleService
    {
        [Inject]
        private ProtectedBrowserStorage LocalStorage { get; set; }
        public event Action OnChange;

        public async Task AddToCart(List<CreateSaleInputModel> item)
        {
            await LocalStorage.SetAsync("cart", item);
            OnChange?.Invoke();
        }
    }
}