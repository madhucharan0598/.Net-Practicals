using Practical6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical6.Controllers
{
    public class ProductDetailsController : Controller
    {
        public ActionResult Index()
        {
            List<Product> P = GetProduct();

            return View("Product", P);
        }

        public ActionResult Details(int id)
        {
            List<Product> P = GetProduct();
            Product selectedProduct = P.FirstOrDefault(x => x.ProductID == id);
            return View(selectedProduct);
        }

        private List<Product> GetProduct()
        {
            List<Product> P = new List<Product>();

            Product p1 = new Product();
            p1.ProductID = 101;
            p1.ProductName = "Mobile";
            p1.Category = "Mobile";
            p1.Price = 10000;
            p1.Imageurl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=150";

            Product p2 = new Product();
            p2.ProductID = 102;
            p2.ProductName = "Laptop";
            p2.Category = "Electronics";
            p2.Price = 65000;
            p2.Imageurl = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=150";

            Product p3 = new Product();
            p3.ProductID = 103;
            p3.ProductName = "HeadPhones";
            p3.Category = "Accessories";
            p3.Price = 1500;
            p3.Imageurl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=150";

            P.Add(p1);
            P.Add(p2);
            P.Add(p3);

            return P;
        }
    }
}