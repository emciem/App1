using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AudioPlayEx;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gunting : ContentPage
    {
        public Gunting()
        {
            InitializeComponent();
        }
        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await DisplayAlert("Correct", "Congratulations!", "OK");
                await Navigation.PushAsync(new Hari());
            }
            else
            {
                DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
                await DisplayAlert("Sorry", "Try Again", "OK");
                await Navigation.PushAsync(new Hari());
            }
        }
    }
}