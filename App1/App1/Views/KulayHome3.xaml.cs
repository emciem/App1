using Android.Graphics;
using Android.Media;
using AudioPlayEx;
using Lottie.Forms;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome3 : ContentPage
    {

       


        public KulayHome3()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            animationViewribbon133.Opacity = 0;
           
        }
        private void DragGestureRecognizer_DropCompleted(object sender, DropCompletedEventArgs e)
        {
        
                animationViewribbon133.Opacity = 0;
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
            DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
            Navigation.PushAsync(new KulayHome4(), false);


        }
        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            animationViewribbon133.Opacity = 0;
            
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