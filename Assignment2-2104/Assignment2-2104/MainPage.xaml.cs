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
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using System.Diagnostics;

namespace Assignment2_2104
{
    public sealed partial class MainPage : Page
    {
        private List<Country> countries = new List<Country>
        {
            new Country("France", "Paris"),
            new Country("Germany", "Berlin"),
            new Country("United States", "Washington, D.C."),
            new Country("Japan", "Tokyo"),
            new Country("Australia", "Canberra"),
        };

        private List<ComputerTerm> computerTerms = new List<ComputerTerm>
        {
            new ComputerTerm("CPU", "Central Processing Unit"),
            new ComputerTerm("HTTP", "Hypertext Transfer Protocol"),
            new ComputerTerm("RAM", "Random Access Memory"),
            new ComputerTerm("GPU", "Graphics Processing Unit"),
            new ComputerTerm("URL", "Uniform Resource Locator"),
        };

        public MainPage()
        {
            this.InitializeComponent();

            // Populate the ComboBoxes initially with countries
            CountryComboBox.ItemsSource = countries;
            ComputerTermComboBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ComputerTermDefinitionTextBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CountryComboBox.SelectedItem != null && CountryRadioButton.IsChecked == true)
            {
                Country selectedCountry = (Country)CountryComboBox.SelectedItem;
                CountryCapitalTextBox.Text = selectedCountry.Capital;
            }

            if (ComputerTermComboBox.SelectedItem != null && ComputerTermRadioButton.IsChecked == true)
            {
                ComputerTerm selectedTerm = (ComputerTerm)ComputerTermComboBox.SelectedItem;
                ComputerTermDefinitionTextBox.Text = selectedTerm.FullDefinition;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("RadioButton_Checked event fired.");

            if (CountryRadioButton.IsChecked == true)
            {
                // Switch to displaying countries
                CountryComboBox.Visibility = Visibility.Visible;
                CountryCapitalTextBox.Visibility = Visibility.Visible;

                // Hide computer terms
                ComputerTermComboBox.Visibility = Visibility.Collapsed;
                ComputerTermDefinitionTextBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                // Switch to displaying computer terms
                CountryComboBox.Visibility = Visibility.Collapsed;
                CountryCapitalTextBox.Visibility = Visibility.Collapsed;

                // Show computer terms
                ComputerTermComboBox.Visibility = Visibility.Visible;
                ComputerTermDefinitionTextBox.Visibility = Visibility.Visible;

                // Populate the Computer Term ComboBox with data
                ComputerTermComboBox.ItemsSource = computerTerms;
            }
        }

    }
}
