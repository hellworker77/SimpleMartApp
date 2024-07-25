﻿namespace Application.DTOs.User;

public sealed class RegisterUserDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RepeatedPassword { get; set; }
}