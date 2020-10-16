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
    public partial class esimenejoulu : ContentPage
    {
        public esimenejoulu()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await image.TranslateTo(0, 200, 2000, Easing.BounceIn);
            await image.ScaleTo(2, 2000, Easing.CubicIn);
            await image.RotateTo(360, 2000, Easing.SinInOut);
            await image.ScaleTo(1, 2000, Easing.CubicOut);
            await image.TranslateTo(0, 0, 2000, Easing.BounceOut);
        }
    }
}