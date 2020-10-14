using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace riigipyha
{
    public partial class MainPage : TabbedPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void whichOne()
        {
            string action = await DisplayActionSheet("Mida avada?", "Cancel", null, "Uusaasta", "Iseseisvuspäev", "Suur reede", "Ülestõusmispühade",
                "Kevadpüha", "Nelipühade", "Jaanipäev", "Jõululaupäev", "Esimene jõulupüha", "Teine jõulupüha");
        }
    }
}
