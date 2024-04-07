using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("API/[controller]")]
public class ProductsController(IProductRepository repo) : ControllerBase
{
    private readonly IProductRepository _repo = repo;

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _repo.GetProductsAsync();
        return Ok(products);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        var product = await _repo.GetProductByIdAsync(id);
        return Ok(product);
    }
}