using Microsoft.AspNetCore.Mvc;
using EConnectMvcApp.Application.Interfaces;
using EConnectMvcApp.Domain.Entities;

namespace EConnectMvcApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var data = await _service.GetByIdAsync(id);
        return data == null ? NotFound() : Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Product product)
    {
        await _service.AddAsync(product);
        return Ok();
    }
}