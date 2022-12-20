using AudioPlayEx;
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
    public partial class Number7v2 : ContentPage
    {
        public Number7v2()
        {
            InitializeComponent();
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Number7v3(), false);

        }

        private async void Btn_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage(), false);

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");

        }
    }
}