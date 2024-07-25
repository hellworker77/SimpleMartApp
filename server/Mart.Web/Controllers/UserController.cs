using Application.DTOs.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mart.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController
{
    /// <summary>
    /// Register a new user
    /// </summary>
    /// <param name="registerDto"></param>
    /// <returns></returns>
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserDto registerDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Update user information
    /// </summary>
    /// <param name="updateUserDto"></param>
    /// <returns></returns>
    [Authorize]
    [HttpPut("edit")]
    public async Task<IActionResult> Update(UpdateUserDto updateUserDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// update user information by admin
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="updateUserDto"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpPut("edit/{id:guid}")]
    public async Task<IActionResult> Register(Guid userId, UpdateUserDto updateUserDto)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Delete a user
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Authorize()]
    [HttpDelete("delete")]
    public async Task<IActionResult> Delete()
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Delete a user by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [Authorize(Roles = "Admin")]
    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid userId)
    {
        throw new NotImplementedException();
    }
}