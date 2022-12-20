using Android.Media;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AudioPlayEx;
using System.Threading.Tasks;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome15 : ContentPage
    {
      
        public KulayHome15()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(2500); await this.Navigation.PushAsync(new KulayHome16(), false); }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KulayHome17(), false);
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}