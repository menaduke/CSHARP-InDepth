using System;
using System.Collections.Generic;
using System.Linq; // this is needed for linq to work property
using System.Text;
using Newtonsoft.Json;

namespace CSHARP_InDepth._1._1._3
{
    public class SimpleDataAccessWithLINQ
    {
        public List<object> Products = new List<object>();
        public string InstanceMethod() { return "Hello World"; }
        public void MainInitializer()
        {
            var offers = OffersExample();
            foreach (Product offer in offers)
            {
                Console.WriteLine(JsonConvert.SerializeObject(offer));
                //Console.WriteLine(offer.ToString());
            }
        }


        #region Region Product Example Start
        static IEnumerable<dynamic> OffersExample()
        {
            List<Product> Products = new List<Product>();
            Product product1 = new Product { Name = "apple", SalePrice = 4, Price = 9, Id = 1, Description = "an apple" };
            Product product2 = new Product { Name = "orange", SalePrice = 6, Price = 14, Id = 2, Description = "an orange" };
            Products.Add(product1);
            Products.Add(product2);
            var db = new { Products = Products };
            var offers =
            from product in db.Products
            where product.SalePrice <= product.Price / 2
            orderby product.SalePrice
            select product;
            //new
            //{
            //    product.Id,
            //    product.Description,
            //};
            return offers;
        }
        #endregion Region Product Example End
    }


    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int SalePrice { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id={Id}\n" +
                $"Description='{Description}'\n" +
                $"Name={Name}\n" +
                $"SalePrice={SalePrice}\n" +
                $"Price={Price}\n";
        }
    }
}
