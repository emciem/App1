using Android.Media;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AudioPlayEx;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome13 : ContentPage
    {
      
        public KulayHome13()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KulayHome14());
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}