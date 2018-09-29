using Prism;
using Prism.Ioc;
using YoCity.ViewModels;
using YoCity.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;
using YoCity.Helpers;
using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YoCity
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            HelperFunctions.SetDarkMode();
            //Check if the user wants to stay logged in and go to the main app if they do. Log in otherwise
            if (Settings.StayLoggedIn && Settings.CurrentUser != null)
            {
                await NavigationService.NavigateAsync("MasterTabbedPage");
            }
            else
            {
                await NavigationService.NavigateAsync("MainPage");
            }
        }

        protected override void OnStart()
        {
            base.OnStart();
            AppCenter.Start("android=0a93fd0d-1fac-4461-82df-39e73c751754;" + 
                "uwp={Your UWP App secret here};" +
                "ios=b843fcb1-ec11-430c-a0c4-3c4ece6a16e0;", typeof(Analytics), typeof(Crashes));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();          
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ProfilePage>();
            containerRegistry.RegisterForNavigation<ListMapPage>();
            containerRegistry.RegisterForNavigation<RedeemPointsPage>();
            containerRegistry.RegisterForNavigation<MasterTabbedPage>();
            containerRegistry.RegisterForNavigation<CreateAccountPage>();
            containerRegistry.RegisterForNavigation<SettingsPage>();
            containerRegistry.RegisterForNavigation<DisplayItemPage>();
        }
    }
}
