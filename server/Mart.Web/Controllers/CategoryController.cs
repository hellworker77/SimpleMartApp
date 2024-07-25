using Application.DTOs.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mart.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    /// <summary>
    /// Get all categories
    /// </summary>
    /// <returns></returns>
    [HttpGet("all")]
    public async Task<IList<CategoryDto>> GetAllCategories()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Create a new category
    /// </summary>
    /// <param name="createCategoryDto"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpPost("create")]
    public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Update a category
    /// </summary>
    /// <param name="categoryDto"></param>
    /// <returns></returns>
    [HttpPut("update")]
    public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Delete a category by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        throw new NotImplementedException();
    }
}