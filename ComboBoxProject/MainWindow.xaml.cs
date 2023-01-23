using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using ComboBoxProject;

namespace ComboBoxProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<string> ListOfItems { get; set; }

        public List<OwnColor> ListOfOwnColors { get; set; }

        public MainWindow()
        {
            ListOfOwnColors = new List<OwnColor>();
            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Eng = "Green",
                NameOfColor_Pol = "Zielony",
                OwnOrientation = Orientation.Horizontal,
            });

            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Eng = "Gold",
                NameOfColor_Pol = "Złoty",
                OwnOrientation = Orientation.Vertical
            });

            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Eng = "Red",
                NameOfColor_Pol = "Czerwony",
                OwnOrientation = Orientation.Horizontal,
            });

            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Eng = "Maroon",
                NameOfColor_Pol = "Kasztanowy",
                OwnOrientation = Orientation.Vertical
            });

            InitializeComponent();
            ListOfItems = new List<string>();
            ListOfItems.Add("Pozycja bindowana 0");
            ListOfItems.Add("Pozycja bindowana 1");
            ListOfItems.Add("Pozycja bindowana 2");
            OnPropertyChanged(nameof(ListOfItems));


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
