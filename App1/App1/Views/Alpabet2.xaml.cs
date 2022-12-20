using Android.Media;
using AudioPlayEx;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Alpabet2 : ContentPage
    {
        public Alpabet2 ()
		{
            DependencyService.Get<IAudio>().PlayAudioFile("ILAGAY NATIN ANG MALAKING LETRANG A AT MALIIT NA LETRANG A.m4a");
            InitializeComponent ();
		}
        //private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        //{
        //    Big.Opacity = 0;

        //}
        private void DragGestureRecognizer_DropCompletedBig(object sender, DropCompletedEventArgs e)
        {
               
                
                Big.Opacity = 0;
                BubbleBig.IsVisible = true;
                BubbleBig.RepeatCount = 1;
                BubbleBig.RepeatMode = Lottie.Forms.RepeatMode.Restart;
                BubbleBig.AutoPlay = true;
                DragVal.Text = "1";
            DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
            Navigation.PushAsync(new Atis(), false);
        }

        private void DragGestureRecognizer_DropCompletedSmall(object sender, DropCompletedEventArgs e)
        {
          

                Small.Opacity = 0;
                BubbleSmall.IsVisible = true;
                BubbleSmall.RepeatCount = 1;
                BubbleSmall.RepeatMode = Lottie.Forms.RepeatMode.Restart;
                BubbleSmall.AutoPlay = true;
                DragVal.Text = "0";

                //DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                //DisplayAlert("Correct", "Congratulations!", "OK");
                //Navigation.PushAsync(new KulayHome4(), false);
           


        }


        private void DragGestureRecognizer_DropCompletedWrong(object sender, DropCompletedEventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
            DisplayAlert("Sorry", "Try Again", "OK");


        }
        private async void Btn_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");

        }

    }
}