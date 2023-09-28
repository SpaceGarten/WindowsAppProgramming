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

            // Populate the ComboBoxes
            CountryComboBox.ItemsSource = countries;
            ComputerTermComboBox.ItemsSource = computerTerms;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CountryComboBox.SelectedItem != null)
            {
                Country selectedCountry = (Country)CountryComboBox.SelectedItem;
                CountryCapitalTextBox.Text = selectedCountry.Capital;
            }

            if (ComputerTermComboBox.SelectedItem != null)
            {
                ComputerTerm selectedTerm = (ComputerTerm)ComputerTermComboBox.SelectedItem;
                ComputerTermDefinitionTextBox.Text = selectedTerm.FullDefinition;
            }
        }
    }
}
