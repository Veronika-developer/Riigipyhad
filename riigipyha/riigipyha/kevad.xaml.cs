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
    public partial class kevad : ContentPage
    {
        public kevad()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double radius = Math.Min(absoluteLayout.Width, absoluteLayout.Height) / 2;
            image.AnchorY = radius / image.Height;
            await image.RotateTo(360, 2000);
        }
    }
}