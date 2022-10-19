using App1.Services;
using App1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<AboutPage>();
            DependencyService.Register<AlpabeBonusGameLetterA>();
            DependencyService.Register<Alpabet1>();
            DependencyService.Register<Alpabet2>();
            DependencyService.Register<Bibe>();
            DependencyService.Register<Bola>();
            DependencyService.Register<Dahon>();
            DependencyService.Register<Dino>();
            DependencyService.Register<Elena>();
            DependencyService.Register<Elesi>();
            DependencyService.Register<Gatas>();
            DependencyService.Register<Gitara>();
            DependencyService.Register<Gunting>();
            DependencyService.Register<Hari>();
            DependencyService.Register<Ibon>();
            DependencyService.Register<ItemDetailPage>();
            DependencyService.Register<ItemsPage>();
            DependencyService.Register<Kahon>();
            DependencyService.Register<KulayHome1>();
            DependencyService.Register<KulayHome10>();
            DependencyService.Register<KulayHome11>();
            DependencyService.Register<KulayHome12>();
            DependencyService.Register<KulayHome13>();
            DependencyService.Register<KulayHome14>();
            DependencyService.Register<KulayHome15>();
            DependencyService.Register<KulayHome16>();
            DependencyService.Register<KulayHome17>();
            DependencyService.Register<KulayHome18>();
            DependencyService.Register<KulayHome2>();
            DependencyService.Register<KulayHome3>();
            DependencyService.Register<KulayHome4>();
            DependencyService.Register<KulayHome5>();
            DependencyService.Register<KulayHome6>();
            DependencyService.Register<KulayHome7>();
            DependencyService.Register<KulayHome8>();
            DependencyService.Register<KulayHome9>();
            DependencyService.Register<Langgam>();
            DependencyService.Register<LoginPage>();
            DependencyService.Register<Mannga>();
            DependencyService.Register<NewItemPage>();
            DependencyService.Register<Niyog>();
            DependencyService.Register<Number1>();
            DependencyService.Register<Number10>();
            DependencyService.Register<Number2>();
            DependencyService.Register<Number3>();
            DependencyService.Register<Number4>();
            DependencyService.Register<Number5>();
            DependencyService.Register<Number6>();
            DependencyService.Register<Number7>();
            DependencyService.Register<Number8>();
            DependencyService.Register<Number9>();
            DependencyService.Register<Orasan>();
            DependencyService.Register<Pusa>();
            DependencyService.Register<Rosas>();
            DependencyService.Register<Saging>();
            DependencyService.Register<Timba>();
            DependencyService.Register<Ubas>();
            DependencyService.Register<Walis>();
            DependencyService.Register<Yelo>();

          

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
