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
	public partial class Pusa : ContentPage
	{

        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Pusa2(), false); }
        public Pusa ()
		{
			InitializeComponent ();

            DependencyService.Get<IAudio>().PlayAudioFile("PUSA.m4a");
        }
        
    }
}