using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTestApp.Services;

namespace MauiTestApp.ViewModels;

public partial class LoginPageViewModel : ObservableObject
{
  [ObservableProperty]
  private string _userName = null!;
  
  [ObservableProperty]
  private string _password = null!;

  private LoginService _loginService = new();

  [RelayCommand]
  public async void ProcessLoginAsync()
  {
    try
    {
      if (!string.IsNullOrWhiteSpace(_userName) && !string.IsNullOrWhiteSpace(_password))
      {
        var response = await _loginService.PerformLoginAsync(_userName, _password);

        if (response != null && response.Token != null)
        {
          await Shell.Current.DisplayAlert("Success", $"FullName: {response.Client.FullName}", "Ok");
        }
        else
        {
          await Shell.Current.DisplayAlert("Error", "Authorization Error", "Ok");
        }
      }
      else
      {
        await Shell.Current.DisplayAlert("Error", "All fields required", "Ok");
      }
    }
    catch (Exception ex)
    {
      await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
    }
  }
}
