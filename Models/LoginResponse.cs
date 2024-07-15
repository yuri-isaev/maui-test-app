namespace MauiTestApp.Models;

public class LoginResponse
{
  public Client Client { get; set; } = null!;
  public string? Token { get; set; }
}
