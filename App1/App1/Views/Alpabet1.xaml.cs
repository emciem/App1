using AudioPlayEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alpabet1 : ContentPage
    {
        public Alpabet1()
        {
            InitializeComponent();
            DependencyService.Get<IAudio>().PlayAudioFile("A-ASO.m4a");
        }


        async void OnDrop(object sender, DropEventArgs e)
        {
            if (e.Data.ToString() != "A") { 
            await DisplayAlert("Correct", "Congratulations!", "OK");
                DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
                await Navigation.PushAsync(new Alpabet2());
               
            }
            else
            {
            await DisplayAlert("Sorry", "Try Again", "OK");
                DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
                await Navigation.PushAsync(new Alpabet2());
            }
        }
    }
}