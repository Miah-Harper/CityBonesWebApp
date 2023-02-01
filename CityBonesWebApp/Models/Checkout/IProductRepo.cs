using System.Collections.Generic;

namespace CityBonesWebApp.Models.Checkout
{
    public interface IProductRepo
    {
        //IEnumerable<Product> Product { get; set; }
        ///*Product GetProductID(int productId);*/
        //public IEnumerable<Product> GetAllProducts();
        ///* public IEnumerable<Product> GetAllPictures();*/
        ///

        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);

    }
}
