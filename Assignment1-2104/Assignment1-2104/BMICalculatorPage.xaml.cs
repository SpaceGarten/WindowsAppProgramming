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
    public sealed partial class BMICalculatorPage : Page
    {
        public BMICalculatorPage()
        {
            this.InitializeComponent();
        }

        private void CalculateBMI_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(HeightTextBox.Text, out double height) &&
                double.TryParse(WeightTextBox.Text, out double weight))
            {
                double bmi = (weight / ((height / 100) * (height / 100)));
                ResultTextBlock.Text = $"Your BMI: {bmi:F2}";
            }
            else
            {
                ResultTextBlock.Text = "Please enter valid height and weight.";
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
