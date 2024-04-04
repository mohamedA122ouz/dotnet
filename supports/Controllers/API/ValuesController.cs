using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supports.Data;
using supports.Models;

namespace supports.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController(ApplictionDBContext Db) : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var product = Db.products.ToList<Product>();
            return product;
        }
        [HttpPost]
        public ActionResult<List<Product>> Update(Product product)
        {
            List<Product> result = new();
            var products = Db.products.SingleOrDefault(m=>m.ID == product.ID);
            var temp = new Product();
            temp.ChangeTo(products);
            result.Add(temp);
            products.ChangeTo(product);
            Db.SaveChanges();
            result.Add(products);
            return Ok(result);
        }
        [HttpPost("del")]
        public ActionResult Del(Product del)
        {
            try
            {
                var product = Db.products.SingleOrDefault(p => p.ID == del.ID);
                Db.Remove(product);
                Db.SaveChanges();
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
