using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App.Views
{
    public class SplahsPage : ContentPage
    {
        Image Splahs;
        public SplahsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var abs = new AbsoluteLayout();
            Splahs = new Image()
            {
                Source = "pngwing.png",
                WidthRequest = 450,
                HeightRequest = 450,
                Scale = 0.68

            };
            AbsoluteLayout.SetLayoutFlags(Splahs, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(Splahs, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            abs.BackgroundColor = Color.White;
            abs.Children.Add(Splahs);

            //this.BackgroundColor = Color.FromHex("#6FCAB8");
            this.Content = abs;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //await Splahs.ScaleTo(1, 2000);
            //await Splahs.ScaleTo(0.9, 1500);
            // await Splahs.ScaleTo(2, 250, Easing.Linear);

            await Task.Delay(4000);
            Application.Current.MainPage = new NavigationPage(new InicioPage());

        }
    }
}
