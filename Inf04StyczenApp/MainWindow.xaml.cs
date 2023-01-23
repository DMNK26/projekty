using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inf04StyczenApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string password;

        private void buttonGenerate_Click(object sender, RoutedEventArgs e)
        {
            string smallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string bigLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string digit = "0123456789";
            string specialChar = "!@#$%^&*()_+=-";

            if(!int.TryParse(textBoxPasswordLenght.Text, out int passwordlenght))
            {
                MessageBox.Show("Nieprawidłowa wartość w długości hasła");
                return;
            }

            bool hasBigLetters = checkBoxHasBigLetters.IsChecked.Value;
            bool hasDigit = checkBoxHasDigit.IsChecked.Value;
            bool hasSpecialChar = checkBoxHasSpecialChar.IsChecked.Value;

            password = "";
            Random random = new Random();

            //wersja 1
            if(hasBigLetters)
            {
                password += bigLetters[random.Next(bigLetters.Length)];
            }
            if(hasDigit)
            {
                password += digit[random.Next(digit.Length)];
            }
            if(hasSpecialChar)
            {
                password += specialChar[random.Next(digit.Length)];
            }

            for(int i = 0; i < password.Length; i++)
            {
                password += smallLetters[random.Next(smallLetters.Length)];
            }

            MessageBox.Show(password);
        }
    }
}
