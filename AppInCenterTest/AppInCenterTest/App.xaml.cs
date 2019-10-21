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
      AppCenter.Start("android=985cd169-976b-44f7-b8df-ed6f164661e7",
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
