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
    public partial class Dahon : ContentPage
    {
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Dahon2(), false); }
        public Dahon()
        {
            InitializeComponent();

            DependencyService.Get<IAudio>().PlayAudioFile("DAHON.m4a");
        }
       
    }
}