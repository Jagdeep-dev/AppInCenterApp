using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppInCenterTest.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppInCenterTest
{
  public partial class App : Application
  {

    public App()
    {
      InitializeComponent();


      MainPage = new MainPage();
    }

    protected override void OnStart()
    {
      // Handle when your app starts
      AppCenter.Start("android=606ee751-690c-4d8e-86f3-7487f3945632",
                    typeof(Analytics), typeof(Crashes));
      AppCenter.LogLevel = LogLevel.Verbose;
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
