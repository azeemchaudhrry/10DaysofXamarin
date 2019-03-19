using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Day2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TitleEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfTextAvailable();
        }

        private void ContentEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfTextAvailable();
        }

        private void CheckIfTextAvailable()
        {
            saveBtn.IsEnabled = (!string.IsNullOrEmpty(titleEntry.Text) && !string.IsNullOrEmpty(contentEditor.Text));
        }

        private void SaveBtn_OnClicked(object sender, EventArgs e)
        {
            titleEntry.Text = string.Empty;
            contentEditor.Text = string.Empty;
        }
    }
}
