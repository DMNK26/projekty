using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace zadanie1
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
        public string FirstName { get; set; }
        public string Age { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlockErrorName.Text = "";
            textBlockErrorAge.Text = "";
            Dictionary<string, string> dictionaryOfError = new Dictionary<string, string>();
            if(Validate(textBoxImie.Text, textBoxWiek.Text, dictionaryOfError))
            {
                Summary(textBoxImie.Text, textBoxWiek.Text);//OK
            }
            else
            {
                ThrowError(textBoxImie.Text, textBoxWiek.Text, dictionaryOfError);//Błąd
            }
        }
        private void Button_Click_Bind(object sender, RoutedEventArgs e)
        {
            textBlockErrorName.Text = "";
            textBlockErrorAge.Text = "";
            Dictionary<string, string> dictionaryOfError = new Dictionary<string, string>();
            if (Validate(FirstName, Age, dictionaryOfError))
            {
                Summary(FirstName, Age);//OK
            }
            else
            {
                ThrowError(FirstName, Age, dictionaryOfError);//Błąd
            }
        }
        #region Walidacja
        private bool ValidateNameEmpty(string nameValidate, Dictionary<string, string> dictionaryOfError)
        {
            if (string.IsNullOrWhiteSpace(nameValidate))
            {
                dictionaryOfError.Add("validateName", "Niepodano imienia!");
                return false;
            }

            return true;
        }

        private bool ValidateAgeEmpty(string ageValidate, Dictionary<string, string> dictionaryOfError)
        {
            if (string.IsNullOrWhiteSpace(ageValidate))
            {
                dictionaryOfError.Add("validateAge", "Niepodano wieku!");
                return false;
            }

            return true;
        }
        private bool ValidateAgeIsNumber(string ageValidate, Dictionary<string, string> dictionaryOfError)
        {
            int age;

            bool success = int.TryParse(ageValidate, out age);
            if (!success)
            {
                dictionaryOfError.Add("validateAge", "Nieprawidłowy wiek!");
                return false;
            }

            return true;
        }

        private bool ValidateAgeRange(string ageRange, Dictionary<string, string> dictionaryOfError)
        {
            if (int.TryParse(ageRange, out int age) && (age <= 0 || age > 150))
            {
                dictionaryOfError.Add("validateAge", "Wiek poza zakresem!");
                return false;
            }

            return true;
        }

        private bool ValidateAge(string age, Dictionary<string, string> dictionaryOfError)
        {
            if (ValidateAgeEmpty(age, dictionaryOfError) && ValidateAgeIsNumber(age, dictionaryOfError) && ValidateAgeRange(age, dictionaryOfError))
                return true;

            return false;
        }
        private bool Validate(string name, string age, Dictionary<string, string> dictionaryOfError)
        {
            bool success = true;
            success = success && ValidateNameEmpty(name, dictionaryOfError);
            success = success && ValidateAge(age, dictionaryOfError);

            return success;
        }
        #endregion

        #region Wypisywanie
        //pomyślnie przeszło walidacje
        private void Summary(string summaryName, string summaryAge)
        {
            //wypisywanie imienia
            textBlockSummary.Text = "Witaj, " + summaryName + "!";

            //wypisywanie wieku i pełnoletności
            int age;
            int.TryParse(summaryAge, out age);
            textBlockAge.Text = "Lat: " + age.ToString();
            if (age >= 18)
                textBlockPelnoletnosc.Text = "Jesteś Pełnoletni/a";
            else
                textBlockPelnoletnosc.Text = "Jesteś Niepełnoletni/a";
        }
        //niepomyślnie przeszło walidacje

        private void ThrowError(string errorName, string errorAge, Dictionary<string, string> dictionaryOfError)
        {
            if (dictionaryOfError.ContainsKey("validateName"))
            {
                textBlockErrorName.Text = dictionaryOfError["validateName"];
            }

            if (dictionaryOfError.ContainsKey("validateAge"))
            {
                textBlockErrorAge.Text = dictionaryOfError["validateAge"];
            }
        }
        
        #endregion

    }
}
