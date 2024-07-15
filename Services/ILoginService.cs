using MauiTestApp.Models;

namespace MauiTestApp.Services;

public interface ILoginService
{
  Task<LoginResponse?> PerformLoginAsync(string login, string password);
}
