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

        public IActionResult List() //list
        {
            var products = _ProductRepo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id) //new 
        {
            var product = _ProductRepo.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProduct(int id) //new
        {
            Product prod = _ProductRepo.GetProduct(id);
            if (prod == null)
            {
                return View("Product Not Found");
            }

            return View(prod);
        }

        public IActionResult UpdateProductToDatabase(Product product) //new
        {
            _ProductRepo.UpdateProduct(product);

            return RedirectToAction("View Product", new { id = product.ProductID });
        }
        public IActionResult InsertProduct()
        {
            var prod = _ProductRepo.AssignCategory();
            return View(prod);
        }

        public IActionResult InsertProductToDatabase(Product productToInsert) //new
        {
            _ProductRepo.InsertProduct(productToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(Product product) //new
        {
            _ProductRepo.DeleteProduct(product);
            return RedirectToAction("Index");

        }









        /*public IActionResult List()
         {
             var pictures =_ProductRepo.GetAllPictures();;
             return View(pictures);
        }*/
    }
}
