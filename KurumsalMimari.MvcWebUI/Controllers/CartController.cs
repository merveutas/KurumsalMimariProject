using KurumsalMimari.Business.Abstract;
using KurumsalMimari.Entities.Concrete;
using KurumsalMimari.MvcWebUI.Models;
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
            _cartService.AddToCard(cart, productToBeAdded);
            _cartSessionServices.SetCard(cart);

            TempData.Add("message", string.Format("Your product, {0}, as successfully added to the cart!", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            var cart = _cartSessionServices.GetCart();
            CartSummaryViewModel cartListViewModel = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionServices.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionServices.SetCard(cart);

            TempData.Add("message", string.Format("Your product was successfully removed from the cart!"));

            return RedirectToAction("List");
        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
                return View();

            TempData.Add("message", string.Format("{0} you order is in process", shippingDetails.FirstName));
            return View();

        }
    }
}
