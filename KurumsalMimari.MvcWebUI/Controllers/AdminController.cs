using KurumsalMimari.Business.Abstract;
using KurumsalMimari.Entities.Concrete;
using KurumsalMimari.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KurumsalMimari.MvcWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IProductService _productService;
        ICategorytService _categorytService;

        public AdminController(IProductService productService, ICategorytService categorytService)
        {
            _productService = productService;
            _categorytService = categorytService;
        }

        public IActionResult Index()
        {
            var productListViewModel = new ProductListVieModel
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }

        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categorytService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", "Product as successflully added");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categorytService.GetAll()
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Product as successflully updated");
            }

            return RedirectToAction("Update");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", "Product as successflully deleted");
            return RedirectToAction("Index");
        }
    }
}
