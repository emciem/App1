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
	public partial class Ngipin : ContentPage
	{
        protected async override void OnAppearing() { base.OnAppearing(); await Task.Delay(5000); await this.Navigation.PushAsync(new Ngipin2(), false); }
        public Ngipin()
		{
			InitializeComponent ();

            DependencyService.Get<IAudio>().PlayAudioFile("NIYOG.m4a");
        }
    
        }
    }