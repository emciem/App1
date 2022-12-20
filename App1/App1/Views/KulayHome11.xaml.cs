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
    public partial class KulayHome11 : ContentPage
    {
      
        public KulayHome11()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(2500); await this.Navigation.PushAsync(new KulayHome12(), false); }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KulayHome12(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}