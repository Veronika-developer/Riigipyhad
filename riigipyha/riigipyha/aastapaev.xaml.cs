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
    public partial class aastapaev : ContentPage
    {
        public aastapaev()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            image.Opacity = 0;
            await image.FadeTo(1, 4000);
        }
    }
}