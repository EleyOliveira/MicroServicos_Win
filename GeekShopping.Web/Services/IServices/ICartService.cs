using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface ICartService
    {
        Task<CartViewModel> FindCartUserByUserId(string userId, string token);
    }
}
