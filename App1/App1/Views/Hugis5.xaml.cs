﻿using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hugis5 : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(3000); await this.Navigation.PushAsync(new Hugis6(), false); }
        public Hugis5()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hugis6(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");

        }



    }
}