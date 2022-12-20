using Android.Media;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AudioPlayEx;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome12 : ContentPage
    {
      
        public KulayHome12()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            animationViewribbon133.Opacity = 0;

        }
        private void DragGestureRecognizer_DropCompleted(object sender, DropCompletedEventArgs e)
        {

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
            DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
            Navigation.PushAsync(new KulayHome13(), false);


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


    }
}
