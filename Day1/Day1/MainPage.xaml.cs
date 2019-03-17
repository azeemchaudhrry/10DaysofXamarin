using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Day1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(userEntry.Text) && string.IsNullOrWhiteSpace(userEntry.Text))
            {
                userGreetingLable.IsVisible = false;
                DisplayAlert("Error", "Name cannot be empty!", "Cancel");
            }
            else
            {
                userGreetingLable.IsVisible = true;
                userGreetingLable.Text = $"Hello {userEntry.Text}, welcome to 10 Days of Xamarin";
            }
        }
    }
}
