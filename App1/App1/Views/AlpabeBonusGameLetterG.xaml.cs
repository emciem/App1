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
	public partial class AlpabeBonusGameLetterG : ContentPage
	{
		public AlpabeBonusGameLetterG()
		{
			InitializeComponent ();
		}

        async void Correct1(object sender, DropEventArgs e)
        {

            A1.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            BubbleSmall.IsVisible = true;
            BubbleSmall.AutoPlay = true;
            BubbleSmall.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "4")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new AlpabeBonusGameLetterG2(), false);
            }
        }
        async void Correct2(object sender, DropEventArgs e)
        {

            A2.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            BubbleSmall1.IsVisible = true;
            BubbleSmall1.AutoPlay = true;
            BubbleSmall1.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "4")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new AlpabeBonusGameLetterG2(), false);
            }

        }
        async void Correct3(object sender, DropEventArgs e)
        {


            A3.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            BubbleSmall2.IsVisible = true;
            BubbleSmall2.AutoPlay = true;
            BubbleSmall2.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "4")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new AlpabeBonusGameLetterG2(), false);
            }
        }
        async void Correct4(object sender, DropEventArgs e)
        {

            A4.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            BubbleSmall3.IsVisible = true;
            BubbleSmall3.AutoPlay = true;
            BubbleSmall3.RepeatCount = 1;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "4")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new AlpabeBonusGameLetterG2(), false);
            }

        }


        async void Error(object sender, DropEventArgs e)
        {

            await DisplayAlert("Sorry", "Try Again.", "OK");
            await Navigation.PushAsync(new Bibe(), false);


        }


        async void SnakeShakeClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await snake.TranslateTo(-15, 0, timeout);
            await snake.TranslateTo(15, 0, timeout);
            await snake.TranslateTo(-10, 0, timeout);
            await snake.TranslateTo(10, 0, timeout);
            await snake.TranslateTo(-5, 0, timeout);
            await snake.TranslateTo(5, 0, timeout);
            snake.TranslationX = 0;
        }
        async void EagleShakeClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await Eagle.TranslateTo(-15, 0, timeout);
            await Eagle.TranslateTo(15, 0, timeout);
            await Eagle.TranslateTo(-10, 0, timeout);
            await Eagle.TranslateTo(10, 0, timeout);
            await Eagle.TranslateTo(-5, 0, timeout);
            await Eagle.TranslateTo(5, 0, timeout);
            Eagle.TranslationX = 0;
        }
        async void AtisShakeClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await Atis.TranslateTo(-15, 0, timeout);
            await Atis.TranslateTo(15, 0, timeout);
            await Atis.TranslateTo(-10, 0, timeout);
            await Atis.TranslateTo(10, 0, timeout);
            await Atis.TranslateTo(-5, 0, timeout);
            await Atis.TranslateTo(5, 0, timeout);
            Atis.TranslationX = 0;
        }
        async void SunShakeClicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await Sun.TranslateTo(-15, 0, timeout);
            await Sun.TranslateTo(15, 0, timeout);
            await Sun.TranslateTo(-10, 0, timeout);
            await Sun.TranslateTo(10, 0, timeout);
            await Sun.TranslateTo(-5, 0, timeout);
            await Sun.TranslateTo(5, 0, timeout);
            Sun.TranslationX = 0;
        }

        private async void Btn_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");

        }
    }
}