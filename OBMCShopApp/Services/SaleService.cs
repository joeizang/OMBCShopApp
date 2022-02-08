using Blazored.LocalStorage;
using OBMCShopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public interface ISaleService
    {
        event Action OnChange;
        Task AddToCart(ProductSoldViewModel item);
    }
    public class SaleService : ISaleService
    {
        private readonly ILocalStorageService _localStorage;

        public SaleService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public event Action OnChange;

        public async Task AddToCart(ProductSoldViewModel item)
        {
            var cart = await _localStorage.GetItemAsync<CreateSaleInputModel>("cart");
            if (cart is null)
            {
                var newCart = new CreateSaleInputModel();
                var products = new List<ProductSoldViewModel>
                {
                    item
                };
                newCart.Products = products;
                await _localStorage.SetItemAsync("cart", newCart);
                return;
            }
            cart.Products.Add(item);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange?.Invoke();
        }
    }
}