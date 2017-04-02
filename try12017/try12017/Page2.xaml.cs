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
    public partial class Page2 : ContentPage
    {
        public Page2(string parametre)
        {
            InitializeComponent();
            test.Text = parametre;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("ciaaaaaao ", "seance jeya nchalah ", "mriguel :D");
        }
    }
}
