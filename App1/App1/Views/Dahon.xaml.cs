using AudioPlayEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dahon : ContentPage
    {
        public Dahon()
        {
            InitializeComponent();

            DependencyService.Get<IAudio>().PlayAudioFile("DAHON.m4a");
        }
        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                await DisplayAlert("Correct", "Congratulations!", "OK");
                await Navigation.PushAsync(new Dino());
            }
            else
            {
                await DisplayAlert("Sorry", "Try Again", "OK");
                await Navigation.PushAsync(new Dino());
            }
        }
    }
}