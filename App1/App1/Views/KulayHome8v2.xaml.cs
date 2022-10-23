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
    public partial class KulayHome8v2 : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(1000); await this.Navigation.PushAsync(new KulayHome9(), false); }

        public KulayHome8v2()
        {
            InitializeComponent();
        }

        //private async void Btn_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new KulayHome9());
        //    DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        //    IsStopVisible.GetType();
        //    IsCorrect.GetType();
        //}

        async void OnDrop(object sender, DropEventArgs e)
        {

                await DisplayAlert("Correct", "Congratulations!", "OK");
                await Navigation.PushAsync(new KulayHome9(), false);

        }

       



    }
}