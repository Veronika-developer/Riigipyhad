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
    public partial class suur : ContentPage
    {
        public suur()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Func<double, double> CustomEaseFunc = t => 9 * t * t * t - 13.5 * t * t + 5.5 * t;
            await image.TranslateTo(0, 200, 2000, CustomEaseFunc);
            await image.TranslateTo(0, 0, 2000, CustomEaseFunc);
        }
    }
}