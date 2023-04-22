using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;
using System.Net.Http.Headers;

namespace GeekShopping.Web.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/cart";

        public CartService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
        
        public async Task<CartViewModel> FindCartUserByUserId(string userId, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.GetAsync($"{BasePath}/find-cart/{userId}");
            return await response.ReadContentAs<CartViewModel>();
        }

        public async Task<bool> RemoveFromCart(long cartId, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<CartViewModel> AddItemToCart(CartViewModel cart, string token)
        {
            throw new NotImplementedException();
        }
        
        public async Task<CartViewModel> UpdateCart(CartViewModel cart, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ApplyCoupon(CartViewModel cart, string couponCode, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<CartViewModel> Checkout(CartHeaderViewModel cartHeader, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ClearCart(string userId, string token)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> RemoveCoupon(string userId, string token)
        {
            throw new NotImplementedException();
        }               
    }
}
