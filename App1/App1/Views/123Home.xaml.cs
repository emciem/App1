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
	public partial class _123Home : ContentPage
	{
		
		public _123Home ()
		{
			InitializeComponent ();
		}
		private async void Btn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number1(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("isa.mp3");
		}
		//private async void Btn_Clicked2(object sender, EventArgs e)
		//{
		//	await Navigation.PushAsync(new Number2(), false);
		//	DependencyService.Get<IAudio>().PlayAudioFile("2.mp3");
		//}
		private async void Btn_Clicked3(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number3(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("3.mp3");
		}
		private async void Btn_Clicked4(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number4(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("4.mp3");
		}
		private async void Btn_Clicked5(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number5(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("5.mp3");
		}
		private async void Btn_Clicked6(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number6(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("6.mp3");
		}
		private async void Btn_Clicked7(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number7(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("7.mp3");
		}
		private async void Btn_Clicked8(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number8(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("8.mp3");
		}
		private async void Btn_Clicked9(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number9(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("9.mp3");
		}
		private async void Btn_Clicked10(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Number10(), false);
			DependencyService.Get<IAudio>().PlayAudioFile("10.mp3");
		}

	}

}