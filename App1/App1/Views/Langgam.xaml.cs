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
	public partial class Langgam : ContentPage
	{
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Langgam2(), false); }
        public Langgam ()
		{
			InitializeComponent ();
        }
        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await Navigation.PushAsync(new Alpabet2(), false);
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

