﻿using MauiTestApp.Models;

namespace MauiTestApp;

public partial class App : Application
{
  public static User user;

  public App()
  {
    InitializeComponent();

    MainPage = new AppShell();
  }
}
