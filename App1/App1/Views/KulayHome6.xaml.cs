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
    public partial class KulayHome6 : ContentPage
    {
     
        public KulayHome6()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(2500); await this.Navigation.PushAsync(new KulayHome7(), false); }
        async void OnDrop(object sender, DropEventArgs e)
        {

            DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
            await Navigation.PushAsync(new KulayHome7(), false);


        }

       


    }
}
