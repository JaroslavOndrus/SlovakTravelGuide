using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlovakTravelGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartMenu : ContentPage
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        async void btnTravelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectPage());
        }
    }
}