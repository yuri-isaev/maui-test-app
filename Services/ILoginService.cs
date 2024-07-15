using MauiTestApp.Models;

namespace MauiTestApp.Services;

public interface ILoginService
{
  Task<LoginResponse> Login(string login, string password);
}
