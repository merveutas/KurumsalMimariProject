using KurumsalMimari.Business.Abstract;
using KurumsalMimari.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KurumsalMimari.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page=1,int category=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListVieModel model = new ProductListVieModel
            {
                Products = products.Skip((page - 1)*pageSize).Take(pageSize).ToList()
            };

            return View(model);
        }
    }
}
