using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models
{
    public class Repository
    {

        static Repository()
        {

            _categories.Add(new Category
            {
                CategoryId = 1,
                Name = "Telefon"
            });

            _categories.Add(new Category
            {
                CategoryId = 2,
                Name = "Bilgisayar"
            });

            _products.Add(new Product { ProductId = 1, Name = "Iphone 13", CategoryId = 1, IsActive = true, Price = 40999, Image = "2.jpg" });
            _products.Add(new Product { ProductId = 1, Name = "Iphone 14", CategoryId = 1, IsActive = true, Price = 57999, Image = "1.jpg" });
            _products.Add(new Product { ProductId = 1, Name = "Samsung S21 Ultra", CategoryId = 1, IsActive = true, Price = 35999, Image = "4.jpg" });
            _products.Add(new Product { ProductId = 1, Name = "Huwai S22", CategoryId = 1, IsActive = true, Price = 25999, Image = "3.jpg" });
            _products.Add(new Product { ProductId = 2, Name = "Toplama PC", CategoryId = 2, IsActive = true, Price = 45999, Image = "5.jpg" });
            _products.Add(new Product { ProductId = 2, Name = "Macbook Air M2", CategoryId = 2 , IsActive = true , Price = 62999 , Image="6.jpeg" });


        }


 
        private static readonly List<Product> _products = new();

        private static readonly List<Category> _categories = new();

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        
    }
}