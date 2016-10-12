using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using testService.Models;

namespace testService.Controllers
{
    public class ProductController : ApiController
    {
        static IList<Product>  listProduct = new List<Product>();
        public IList<Product> Get()
        {
            return listProduct;
        }

        public bool Post(int? id, string name)
        {
            listProduct.Add(new Product { id = id, name = name });
            return true;

        }

        public bool Put([FromUri]int id, Product productMod)
        {
            var product  = listProduct.First(x => x.id == id);
            product.id = productMod.id;
            product.name = productMod.name;
            return true;
        }
        public bool Delete([FromUri]int id)
        {
            var product  = listProduct.First(x => x.id == id);
            listProduct.Remove(product);
            return true;
        }
    }
}
