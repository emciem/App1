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
	public partial class Unggoy2 : ContentPage
	{
		public Unggoy2()
		{
			InitializeComponent ();

            DependencyService.Get<IAudio>().PlayAudioFile("TIMBA.m4a");
        }
        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {

                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new AlpabeBonusGameLetterU(), false);
            }
            else
            {

                DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
                await DisplayAlert("Sorry", "Try Again", "OK");
                
            }
        }
    }
}