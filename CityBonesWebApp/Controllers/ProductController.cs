using CityBonesWebApp.Models;
using CityBonesWebApp.Models.Checkout;
using Microsoft.AspNetCore.Mvc;

namespace CityBonesWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IProductRepo _ProductRepo;

        public ProductController(ICategoryRepo categoryRepo, IProductRepo productRepo)
        {

            _categoryRepo = categoryRepo;
            _ProductRepo = productRepo;
        }

        public IActionResult List()
        {
            var products = _ProductRepo.GetAllProducts();
            return View(products);
        }

        /*public IActionResult List()
         {
             var pictures =_ProductRepo.GetAllPictures();;
             return View(pictures);
         }*/
    }
}
