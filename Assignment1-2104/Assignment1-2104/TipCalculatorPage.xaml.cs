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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment1_2104
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TipCalculatorPage : Page
    {
        public TipCalculatorPage()
        {
            this.InitializeComponent();
        }

        private void CalculateTip_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(BillAmountTextBox.Text, out double billAmount) &&
                double.TryParse(TipPercentageTextBox.Text, out double tipPercentage))
            {
                double tipAmount = (billAmount * tipPercentage) / 100;
                TipAmountTextBlock.Text = $"Tip Amount: ${tipAmount:F2}";
            }
            else
            {
                TipAmountTextBlock.Text = "Please enter valid bill amount and tip percentage.";
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
