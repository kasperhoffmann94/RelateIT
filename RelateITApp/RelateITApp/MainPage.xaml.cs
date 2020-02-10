using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RelateITApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.Idiom == TargetIdiom.Phone)
            {
                PhoneView.IsVisible = true;
                TabletView.IsVisible = false;
            }
            else
            {
                PhoneView.IsVisible = false;
                TabletView.IsVisible = true;
            }
        }


        private void SaveButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ChangeRoute_Clicked(object sender, EventArgs e)
        {
        }
    }
}
