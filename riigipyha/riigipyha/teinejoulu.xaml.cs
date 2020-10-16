using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace riigipyha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class teinejoulu : ContentPage
    {
        public teinejoulu()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await image.ScaleTo(2, 2000);
            await image.ScaleTo(1, 2000);
        }
    }
}