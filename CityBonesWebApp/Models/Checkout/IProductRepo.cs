using System.Collections.Generic;

namespace CityBonesWebApp.Models.Checkout
{
    public interface IProductRepo
    {
        IEnumerable<Product> Product { get; set; }
        /*Product GetProductID(int productId);*/
        public IEnumerable<Product> GetAllProducts();
        /* public IEnumerable<Product> GetAllPictures();*/
    }
}
