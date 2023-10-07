using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment_3___CSTP2104
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click_Country1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Country1));
        }

        private void Button_Click_Country2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Country2));
        }

        private void Button_Click_Country3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Country3));
        }

        private void Button_Click_Country4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Country4));
        }

        private void Button_Click_Country5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Country5));
        }
    }



}
