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
	public partial class Unggoy : ContentPage
	{
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Unggoy2(), false); }
        public Unggoy()
		{
			InitializeComponent ();

            DependencyService.Get<IAudio>().PlayAudioFile("TIMBA.m4a");
        }
        
    }
}