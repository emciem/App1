using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome10 : ContentPage
    {
      
        public KulayHome10()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KulayHome10v2());

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }

        async void OnDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Correct", "Congratulations!", "OK");
            await Navigation.PushAsync(new KulayHome10v2());

        }


    }
}