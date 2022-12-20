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
    public partial class Elesi : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Elesi2(), false); }
        public Elesi()
        {
            InitializeComponent();

            DependencyService.Get<IAudio>().PlayAudioFile("ELESI.m4a");
        }

        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await Navigation.PushAsync(new Elesi2(), false);
                //await labelAnimated.TranslateTo(-100, 0, 1000);
            }
            else
            {
                await DisplayAlert("Sorry", "Try Again", "OK");
                DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");

            }
        }
    }
}