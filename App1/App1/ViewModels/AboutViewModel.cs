using App1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command Next { get; }

        public AboutViewModel()
        {
            try
            {
                Next = new Command(OnLoginClicked);
            }
            catch
            {
               
            }
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one

            try
            {
                await Shell.Current.GoToAsync($"//{nameof(Number1)}");
            }
            catch
            {

            }
        }
    }
}
