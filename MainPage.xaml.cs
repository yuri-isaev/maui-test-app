using MauiTestApp.ViewModels;

namespace MauiTestApp;

public partial class MainPage
{
  public MainPage()
  {
    InitializeComponent();
    BindingContext = new LoginPageViewModel();
  }
}
