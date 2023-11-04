using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace laboratorio08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ItemBattery.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatteryDemo());
            };
            ItemQR.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new QrScanningDemo());
            };
        }
    }
}
