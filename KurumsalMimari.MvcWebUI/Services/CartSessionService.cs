using KurumsalMimari.Entities.Concrete;
using KurumsalMimari.MvcWebUI.ExtensionMethods;
using Microsoft.AspNetCore.Http;

namespace KurumsalMimari.MvcWebUI.Services
{
    public class CartSessionService : ICartSessionServices
    {
        IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCard(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
        }
    }
}
