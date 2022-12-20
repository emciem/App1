using Android.App;
using Android.Content.PM;
using Android.Media;
using App1.Services;
using App1.ViewModels;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        void OnDragStarting(object sender, DragStartingEventArgs e)
        {
            //Shape shape = (sender as Element).Parent as Shape;
            //e.Data.Properties.Add("Square", new Square(shape.Width, shape.Height));
        }

        void OnDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;
        }

        //async System.Threading.Tasks.Task<string> OnDrop(object sender, DropEventArgs e)
        //{
        //    string text = await e.Data.GetTextAsync();
        //    return "testting";

        //}
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");
            await Navigation.PushAsync(new Alpabet1(), false);
        }

        private async void Btn123_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");
            await Navigation.PushAsync(new _123Home(), false);
        }
        private async void BtnKulay_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");
            await Navigation.PushAsync(new KulayHome1(), false);
        }
        private async void BtnHugis_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");
            await Navigation.PushAsync(new Hugis1(), false);
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().StopAudioFile("BGMusicv2.mp3");
            await Navigation.PushAsync(new AboutPage(), false);
        }


        private async void Btn_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");

        }

    }

        
        
        

    }


