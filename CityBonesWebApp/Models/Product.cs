using System.Collections.Generic;

namespace CityBonesWebApp.Models
{
    public class Product
    {
        public int ProductID { get; set; } 
        public string Name { get; set; }
        public string Category { get; set; }

        public double Price { get; set; }

        public int StockLevel { get; set; }

        public int OnSale { get; set; }

        //public string ShortDescription { get; set; }
        //public string LongDescription { get; set; }
        //public decimal Price { get; set; }
        //public string ImageUrl { get; set; }
        //public string ImageThumbnailUrl { get; set; }
        //public int StockLevel { get; set; }
        //public string OnSale { get; set; }
        //public bool InStock { get; set; }
        //public string Pictures { get; set;}

        public IEnumerable<Category> Categories { get; set; }
    }
}
