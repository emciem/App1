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
	public partial class AlpabeBonusGameLetterS2 : ContentPage
	{
		public AlpabeBonusGameLetterS2()
		{
			InitializeComponent ();
		}

        async void Correct1(object sender, EventArgs e)
        {

            A1.IsVisible = false;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble1.IsVisible = true;
            bubble1.AutoPlay = true;
            bubble1.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "5")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Timba(), false);
            }
        }
        async void Correct2(object sender, EventArgs e)
        {

            A2.IsVisible = false;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble12.IsVisible = true;
            bubble12.AutoPlay = true;
            bubble12.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "5")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Timba(), false);
            }

        }
        async void Correct3(object sender, EventArgs e)
        {


            A3.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble13.IsVisible = true;
            bubble13.AutoPlay = true;
            bubble13.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "5")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Timba(), false);
            }
        }
        async void Correct4(object sender, EventArgs e)
        {

            A4.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble14.IsVisible = true;
            bubble14.AutoPlay = true;
            bubble14.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "5")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Timba(), false);
            }

        }

        async void Correct5(object sender, EventArgs e)
        {

            A5.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble15.IsVisible = true;
            bubble15.AutoPlay = true;
            bubble15.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "5")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Timba(), false);
            }

        }


        async void Error(object sender, DropEventArgs e)
        {

            await DisplayAlert("Sorry", "Try Again.", "OK");
            await Navigation.PushAsync(new Bibe(), false);


        }


        async void Lose1(object sender, EventArgs e)
        {

            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await W1.TranslateTo(-15, 0, timeout);
            await W1.TranslateTo(15, 0, timeout);
            await W1.TranslateTo(-10, 0, timeout);
            await W1.TranslateTo(10, 0, timeout);
            await W1.TranslateTo(-5, 0, timeout);
            await W1.TranslateTo(5, 0, timeout);
            W1.TranslationX = 0;
            W1.Opacity = 0;
        }
        async void Lose2(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await W2.TranslateTo(-15, 0, timeout);
            await W2.TranslateTo(15, 0, timeout);
            await W2.TranslateTo(-10, 0, timeout);
            await W2.TranslateTo(10, 0, timeout);
            await W2.TranslateTo(-5, 0, timeout);
            await W2.TranslateTo(5, 0, timeout);
            W2.TranslationX = 0;
            W2.Opacity = 0;
        }
        async void Lose3(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await W3.TranslateTo(-15, 0, timeout);
            await W3.TranslateTo(15, 0, timeout);
            await W3.TranslateTo(-10, 0, timeout);
            await W3.TranslateTo(10, 0, timeout);
            await W3.TranslateTo(-5, 0, timeout);
            await W3.TranslateTo(5, 0, timeout);
            W3.TranslationX = 0;
            W3.Opacity = 0;
        }



    }
}