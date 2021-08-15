using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismTest.ViewModels;
using PrismTest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(new System.Uri("/NavigationPage/LoginPage"));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LoginPage,LoginPageViewModel>();
        }

        //protected override void OnStart()
        //{
        //}

        //protected override void OnSleep()
        //{
        //}

        //protected override void OnResume()
        //{
        //}
    }
}
