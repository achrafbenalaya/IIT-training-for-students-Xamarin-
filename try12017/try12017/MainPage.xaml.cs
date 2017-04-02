using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace try12017
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CC1(object sender, EventArgs e)
        {
         var k = await DisplayAlert("Hello", "Do  you want to change ?", "accept", "No");

            if (k == true)
            {
                SwitchA.IsToggled = false;
               

            }
            else
            {
                lab1.Text = "Go go ";
            }

        }
    }
}
