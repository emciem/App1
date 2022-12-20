using Android.Media;
using AudioPlayEx;
using Lottie.Forms;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kulay23 : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(1000); await this.Navigation.PushAsync(new Kulay24(), false); }
        public Kulay23()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            (sender as AnimationView).IsVisible = false;

        }



        private void Btn_Clicked_ribbon(object sender, EventArgs e)
        {
            (sender as AnimationView).IsVisible = false;

        }

        private async void Btn_Clicked_Rose(object sender, EventArgs e)
        {
            (sender as AnimationView).IsVisible = false;

            await Navigation.PushAsync(new Kulay24(), false);
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }

    }
}