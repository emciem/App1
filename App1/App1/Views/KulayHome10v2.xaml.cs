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
    public partial class KulayHome10v2 : ContentPage
    {

        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(1000); await this.Navigation.PushAsync(new KulayHome11(), false); }
        public KulayHome10v2()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KulayHome11(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
        }

        async void OnDrop(object sender, DropEventArgs e)
        {

            DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
            await Navigation.PushAsync(new KulayHome11(), false);

        }

    }
}