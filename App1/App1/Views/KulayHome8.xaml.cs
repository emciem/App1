using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KulayHome8 : ContentPage
    {
        //private bool _isStopVisible;

        //public bool IsStopVisible
        //{
        //    get
        //    {
        //        return _isStopVisible;
        //    }
        //    set
        //    {
        //        _isStopVisible = value;
        //        OnPropertyChanged("IsStopVisible");
        //    }

        //}

        //private bool _isCorrect;

        //public bool IsCorrect
        //{
        //    get
        //    {
        //        return _isCorrect;
        //    }
        //    set
        //    {
        //        _isCorrect = value;
        //        OnPropertyChanged("IsCorrect");
        //    }

        //}

        public KulayHome8()
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
                await Navigation.PushAsync(new KulayHome8v2());
           
        }

       



    }
}