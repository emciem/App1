using Android.Media;
using AudioPlayEx;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hugis1 : ContentPage

    {
       
        public Hugis1()
        {
            InitializeComponent();
        }
       

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
       

        }
        private void DragGestureRecognizer_DropCompleted(object sender, DropCompletedEventArgs e)
        {

            DependencyService.Get<IAudio>().PlayAudioFile("Complete.m4a");
            DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
            Navigation.PushAsync(new KulayHome4(), false);


        }
        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {


        }


        private void DragGestureRecognizer_DropCompletedWrong(object sender, DropCompletedEventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose.m4a");
            DisplayAlert("Sorry", "Try Again", "OK");


        }


        async void Correct1(object sender, EventArgs e)
        {

            BeachBall.IsVisible = false;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble1.IsVisible = true;
            bubble1.AutoPlay = true;
            bubble1.RepeatCount = 3;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "3")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Bola(), false);
            }
        }
        async void Correct2(object sender, EventArgs e)
        {

            Donut.IsVisible = false;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble2.IsVisible = true;
            bubble2.AutoPlay = true;
            bubble2.RepeatCount = 3;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "3")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Bola(), false);
            }

        }
        async void Correct3(object sender, EventArgs e)
        {


            Clock.Opacity = 0;
            int counter = Convert.ToInt32(lblVal.Text.ToString());
            lblVal.Text = Convert.ToString(counter + 1);
            bubble3.IsVisible = true;
            bubble3.AutoPlay = true;
            bubble3.RepeatCount = 3;
            DependencyService.Get<IAudio>().PlayAudioFile("Win1.wav");
            if (lblVal.Text == "3")
            {
                DependencyService.Get<IAudio>().PlayAudioFile("MAHUSAY.m4a");
                await Navigation.PushAsync(new Bola(), false);
            }
        }


        async void Lose(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await pizza.TranslateTo(-15, 0, timeout);
            await pizza.TranslateTo(15, 0, timeout);
            await pizza.TranslateTo(-10, 0, timeout);
            await pizza.TranslateTo(10, 0, timeout);
            await pizza.TranslateTo(-5, 0, timeout);
            await pizza.TranslateTo(5, 0, timeout);
            pizza.TranslationX = 0;

        }
        async void Lose1(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await Cheese.TranslateTo(-15, 0, timeout);
            await Cheese.TranslateTo(15, 0, timeout);
            await Cheese.TranslateTo(-10, 0, timeout);
            await Cheese.TranslateTo(10, 0, timeout);
            await Cheese.TranslateTo(-5, 0, timeout);
            await Cheese.TranslateTo(5, 0, timeout);
            Cheese.TranslationX = 0;

        }
        async void Lose2(object sender, EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("Lose1.wav");
            uint timeout = 50;
            await Chocolate.TranslateTo(-15, 0, timeout);
            await Chocolate.TranslateTo(15, 0, timeout);
            await Chocolate.TranslateTo(-10, 0, timeout);
            await Chocolate.TranslateTo(10, 0, timeout);
            await Chocolate.TranslateTo(-5, 0, timeout);
            await Chocolate.TranslateTo(5, 0, timeout);
            Chocolate.TranslationX = 0;

        }

    }
}