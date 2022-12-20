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
	public partial class Mannga : ContentPage
	{
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Mannga2(), false); }
        public Mannga ()
		{
			InitializeComponent ();

            DependencyService.Get<IAudio>().PlayAudioFile("MANGGA.m4a");
        }

        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await Navigation.PushAsync(new Mannga2(), false);
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
