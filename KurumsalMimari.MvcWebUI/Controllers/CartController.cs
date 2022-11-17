using KurumsalMimari.Business.Abstract;
using KurumsalMimari.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KurumsalMimari.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        ICartSessionServices _cartSessionServices;
        ICartService _cartService;
        IProductService _productService;

        public CartController(ICartSessionServices cartSessionServices, ICartService cartService, IProductService productService)
        {
            _cartSessionServices = cartSessionServices;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionServices.GetCart();
            _cartService.AddToCard(cart,productToBeAdded);
            _cartSessionServices.SetCard(cart);

            TempData.Add("message", string.Format("Your product, {0}, as successfully added to the cart!", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");
        }
    }
}
