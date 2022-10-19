using App1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Command Next { get; }

        public ItemDetailViewModel()
        {
            Next = new Command(LoginClicked);
        }

        private async void LoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ItemDetailPage)}");
        }
    }
}
