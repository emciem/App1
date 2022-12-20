using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class kulay30 : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(1000); await this.Navigation.PushAsync(new KulayHome1(), false); }
        public kulay30()
        {
            InitializeComponent();
        }

        


    }
}