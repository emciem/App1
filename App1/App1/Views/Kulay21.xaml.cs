using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kulay21 : ContentPage
    {
      
        public Kulay21()
        {
            InitializeComponent();
        }

        private async void OnDrop(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kulay22());
            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }



    }
}