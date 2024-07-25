using Application.DTOs.Category;
using Application.DTOs.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mart.Web.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    /// <summary>
    /// Get all products
    /// </summary>
    /// <returns></returns>
    [HttpGet("all")]
    public async Task<IList<ProductShortDto>> GetAllProducts()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Get product by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("product/{id:guid}")]
    public async Task<ProductDetailDto> GetProductById(Guid id)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Get product by category
    /// </summary>
    /// <param name="categoryDto"></param>
    /// <returns></returns>
    [HttpGet("product/category")]
    public async Task<IList<ProductShortDto>> GetProductById(CategoryDto categoryDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Create a new product
    /// </summary>
    /// <param name="createProductDto"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpPost("create")]
    public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Update a product
    /// </summary>
    /// <param name="updateProductDto"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpPut("update")]
    public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Delete a product by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        throw new NotImplementedException();
    }
}