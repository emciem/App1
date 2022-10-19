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
	public partial class Alpabet2 : ContentPage
	{
		public Alpabet2 ()
		{
			InitializeComponent ();
		}
        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                await DisplayAlert("Correct", "Congratulations!", "OK");
                await Navigation.PushAsync(new AlpabeBonusGameLetterA());
            }
            else
            {
                await DisplayAlert("Sorry", "Try Again", "OK");
                await Navigation.PushAsync(new AlpabeBonusGameLetterA());
            }
        }
    }
}