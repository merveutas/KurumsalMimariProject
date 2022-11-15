using KurumsalMimari.Business.Abstract;
using KurumsalMimari.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KurumsalMimari.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListVieModel model = new ProductListVieModel
            {
                Products = products
            };

            return View(model);
        }
    }
}
