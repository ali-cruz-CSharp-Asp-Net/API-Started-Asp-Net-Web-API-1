using ProductsApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ProductsApp.Controllers
{
    public class ProductsController : Controller
    {
        Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
            new Product {Id = 2, Name = "Yo-Yo", Category = "Toys", Price = 3.75M},
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public HttpStatusCodeResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            
            if (product == null) 
            {
                //return NotFound();
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
                //return new StatusCodeResult();
            }

            //return Ok(product);
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}