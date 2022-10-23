﻿using AudioPlayEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Yelo2 : ContentPage
	{
		public Yelo2 ()
		{
			InitializeComponent ();

            DependencyService.Get<IAudio>().PlayAudioFile("YELO.m4a");
        }

        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await DisplayAlert("Correct", "Congratulations!", "OK");
                await Navigation.PushAsync(new Bibe(), false);
            }
            else
            {
                DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
                await DisplayAlert("Sorry", "Try Again", "OK");

            }
        }
    }
}