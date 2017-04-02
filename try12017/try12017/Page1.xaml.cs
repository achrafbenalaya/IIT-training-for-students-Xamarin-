using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace try12017
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
           
        }

        private void bb1(object sender, EventArgs e)
        {
            DisplayAlert("Bonjour", "mar7ba bikom", "ok");
            label1.Text = "Sarwa9t el pause wala";
        }

        private async void bb2(object sender, EventArgs e)
        {
           var s =await DisplayAlert("Hello", "would you marry me", "Yes", "No");
            if (s==true)
            { but1.Text = "Cbon"; }
            else
            {
                labe2.IsVisible = true;
            }
            
        }

        private void Switch1_OnToggled(object sender, ToggledEventArgs e)
        {
            if (Switch1.IsToggled == true)
            {
                but1.IsEnabled = false;
                but2.IsVisible = false;
                
            }
            else
            {
                but1.IsEnabled = true;
                but2.IsVisible = true;
                
            }
        }

        private async void changeback(object sender, EventArgs e)
        {
           string  k= await  DisplayActionSheet("a5tar couleur","Cancel","Destruction","red", "blue", "white", "green");
            if (k=="red")
            {
               BackgroundColor=Color.Red; 
            }
            else if (k == "green")
            {
                BackgroundColor=Color.Green;
            }

            else if (k== "blue")
            {
                but2.BackgroundColor=Color.Blue;
            }
            {
                
            }

        }

        private async void Gotopage2(object sender, EventArgs e)
        {
           // string par = label1.Text;
            await Navigation.PushAsync(new Page2(label1.Text));
        }
    }
}
