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

namespace Assignment4_2104
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int randomNumber;
        private bool gameActive = true;

        public MainPage()
        {
            this.InitializeComponent();
            GenerateRandomNumber();
        }

        private void GenerateRandomNumber()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 11); // Generates a random number between 1 and 10
        }

        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (!gameActive)
                return;

            if (int.TryParse(guessTextBox.Text, out int userGuess))
            {
                if (userGuess < randomNumber)
                {
                    resultTextBox.Text = "Answer is too small! Guess again!";
                }
                else if (userGuess > randomNumber)
                {
                    resultTextBox.Text = "Answer is too large! Guess again!";
                }
                else
                {
                    resultTextBox.Text = "Correct!";
                    gameActive = false;
                }
            }
        }

        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            gameActive = true;
            GenerateRandomNumber();
            guessTextBox.Text = string.Empty;
            resultTextBox.Text = string.Empty;
        }
    }
}
