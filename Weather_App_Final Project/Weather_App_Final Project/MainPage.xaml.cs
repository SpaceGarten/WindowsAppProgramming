using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Weather_App_Final_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private readonly string Lat = "49.2827";
        private readonly string Lng = "-123.1207";
        public MainPage()
        {
            this.InitializeComponent();
            HideStatusBar();
        }

        private async void HideStatusBar()
        {
            if(ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0))
            {
                var statusBar = StatusBar.GetForCurrentView();
                await statusBar.HideAsync();
            }
        }

        private async void btnGetWeather_Click(object sender, RoutedEventArgs e)
        {
            progressRing.IsActive = true;
         

          

            var data = await Helper.Helper.GetWeather(Lat, Lng);
            if(data != null)
            {
                txtCity.Text = $"{data.name}, {data.sys.country}";
                txtLastUpdate.Text = $"Last updated : {DateTime.Now.ToString("dd MMMM yyyy HH:mm")}";

                BitmapImage image = new BitmapImage(new Uri($"http://openweathermap.org/img/w/{data.weather[0].icon}.png", UriKind.Absolute));
                imgWeather.Source = image;

                txtDescription.Text = $"{data.weather[0].description}";
                txtHumidity.Text = $"Humidity : {data.main.humidity} %";
                txtTime.Text = $"{Common.Common.ConvertUnixToDateTime(data.sys.sunrise).ToString("HH:mm")} / {Common.Common.ConvertUnixToDateTime(data.sys.sunset).ToString("HH:mm")}";

                txtCel.Text=$"{data.main.temp} °C";
            }

            progressRing.IsActive = false;
        }
    }
}
