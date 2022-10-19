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
    public partial class Number9 : ContentPage
    {
        public Number9()
        {
            InitializeComponent();
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Number9v2());
            DependencyService.Get<IAudio>().PlayAudioFile("9.mp3");
        }
    }
}