using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, ProductName = "Laptop", Price = 999.99M },
        new Product { Id = 2, ProductName = "Smartphone", Price = 499.99M },
        new Product { Id = 3, ProductName = "Tablet", Price = 299.99M }
    };
    
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return Ok(_products);
    }
}