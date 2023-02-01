using Dapper;
using System.Collections.Generic;
using System.Data;

namespace CityBonesWebApp.Models
{

    public class AdminInventoryRepo : IAdminInventoryRepo
    { 
        private readonly IDbConnection _conn;

        public AdminInventoryRepo(IDbConnection conn)
        {
            _conn = conn;
        }


        public Product AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Product();
            product.Categories = categoryList;

            return product;
        }

        public void DeleteProduct(Product product)
        {

            _conn.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = product.ProductID });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM category;");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingleOrDefault<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORY) VALUES (@name, @price, @category);",
               new { name = productToInsert.Name, price = productToInsert.Price, category = productToInsert.Categories });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
             new { name = product.Name, price = product.Price, id = product.ProductID });
        }

    }
}

