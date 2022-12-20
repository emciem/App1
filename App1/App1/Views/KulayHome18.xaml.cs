using Android.Media;
using App1.ViewModels;
using AudioPlayEx;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome18 : ContentPage
    {
      
        public KulayHome18()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(2500); await this.Navigation.PushAsync(new Kulay19(), false); }
        private async void OnDrop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kulay19(), false);
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}