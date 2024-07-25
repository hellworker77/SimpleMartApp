using Application.DTOs.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mart.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    /// <summary>
    /// Get all orders
    /// </summary>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpGet("all")]
    public async Task<IList<OrderDto>> GetAllOrders()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Get all orders of current user
    /// </summary>
    /// <returns></returns>
    [Authorize]
    [HttpGet("my")]
    public async Task<IList<OrderDto>> GetMyOrders()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Get all orders of a user
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpGet("user/{id:guid}")]
    public async Task<IList<OrderDto>> GetUserOrders(Guid id)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Get order by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Authorize]
    [HttpGet("order/{id:guid}")]
    public async Task<OrderDetailDto> GetOrderById(Guid id)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Add product to order if not exists create order
    /// </summary>
    /// <param name="orderProductDto"></param>
    /// <returns></returns>
    [Authorize]
    [HttpPost("add")]
    public async Task<IActionResult> AddProductToOrder(OrderProductDto orderProductDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Add product to user's order by id if not exists create order
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="orderProductDto"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpPost("add/{userId:guid}")]
    public async Task<IActionResult> AddProductToOrder(Guid userId, OrderProductDto orderProductDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Edit product in order 
    /// </summary>
    /// <param name="orderProductDto"></param>
    /// <returns></returns>
    [Authorize]
    [HttpPut("edit")]
    public async Task<IActionResult> EditProductInOrder(OrderProductDto orderProductDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Edit product in user's order by id
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="orderProductDto"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpPut("edit/{userId:guid}")]
    public async Task<IActionResult> EditProductInOrder(Guid userId, OrderProductDto orderProductDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Remove product from order
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    [Authorize]
    [HttpDelete("remove")]
    public async Task<IActionResult> RemoveProductFromOrder(Guid productId)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Remove product from user's order by id
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="productId"></param>
    /// <returns></returns>
    [Authorize]
    [HttpDelete("remove/{userId:guid}")]
    public async Task<IActionResult> RemoveProductFromOrder(Guid userId, Guid productId)
    {
        throw new NotImplementedException();
    }
}