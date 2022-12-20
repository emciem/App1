using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kulay19 : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(1000); await this.Navigation.PushAsync(new Kulay20(), false); }
        public Kulay19()
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
            Navigation.PushAsync(new Kulay20(), false);


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