using Android.Media;
using AudioPlayEx;
using Lottie.Forms;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome9 : ContentPage
    {
      
        public KulayHome9()
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

            await Navigation.PushAsync(new KulayHome10(), false);
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }

    }
}