using System.Text;
using MauiTestApp.Models;
using Newtonsoft.Json;

namespace MauiTestApp.Services;

public class LoginService : ILoginService
{
  private HttpClient _client = new();
  private string _url = "https://testwork.cloud39.ru/BonusWebApi/Account/Login";

  public async Task<LoginResponse?> PerformLoginAsync(string login, string password)
  {
    var loginData = new
    {
      Login = login,
      Password = password
    };

    var json = JsonConvert.SerializeObject(loginData);
    var content = new StringContent(json, Encoding.UTF8, "application/json");
    var response = await _client.PostAsync(_url, content);
    
    if (response.IsSuccessStatusCode)
    {
      var responseData = await response.Content.ReadAsStringAsync();
      return JsonConvert.DeserializeObject<LoginResponse>(responseData)!;
    }

    return null;
  }
}
