using KurumsalMimari.MvcWebUI.Models;
using KurumsalMimari.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KurumsalMimari.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        ICartSessionServices _cartsessionServices;

        public CartSummaryViewComponent(ICartSessionServices cartsessionServices)
        {
            _cartsessionServices = cartsessionServices;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartsessionServices.GetCart()
            };
            return View(model);
        }
    }

}
