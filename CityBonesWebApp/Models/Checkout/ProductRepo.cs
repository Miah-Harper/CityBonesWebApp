using CityBonesWebApp.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace CityBonesWebApp.Models.Checkout
{
    public class ProductRepo : IProductRepo //our productrepo depends on a connection to our database and that what we're injecting into this 
    {
        private readonly IDbConnection _conn; //field. this is stored in the start up 


        public ProductRepo(IDbConnection conn) //this conn file gets passed into type IDbconnection, which we then pass into our field ^^ and that gives us our dependency injection. We're injecting this (Idbconn) into our field 
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }

        IEnumerable<Product> IProductRepo.GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
             new { name = product.Name, price = product.Price, id = product.ProductID });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORY) VALUES (@name, @price, @category);",
                new { name = productToInsert.Name, price = productToInsert.Price, category = productToInsert.Category });
        }

        //public IEnumerable<Product> ViewProduct()
        //{
        //    return _conn.Query<Product>("SELECT * FROM products");
        //}
        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM category;");
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
            _conn.Execute("DELETE FROM REVIEWS WHERE ProductID = @id;", new { id = product.ProductID });
            _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;", new { id = product.ProductID });
            _conn.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = product.ProductID });
        }


    }

}

