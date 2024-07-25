namespace Application.DTOs.User;

public sealed class UpdateUserDto
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string RepeatedPassword { get; set; }
    public string OldPassword { get; set; }
}