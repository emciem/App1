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
    public partial class kulay34 : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(1000); await this.Navigation.PushAsync(new kulay35(), false); }
        public kulay34()
        {
            InitializeComponent();
        }

      


    }
}