using LottoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWPF;

namespace LottoWPF.ViewModel
{
    internal class LottoVM : ObserverVM
    {
        public ObservableCollection<ButtonDescription> ButtonList { get; set; }

        int numberOfButton = 50;

        public LottoVM()
        {
            ButtonList = new ObservableCollection<ButtonDescription>();
            for(int i = 0; i < numberOfButton; i++)
            {
                ButtonList.Add(new ButtonDescription()
                {
                    Name = i.ToString(),
                    Index = i,
                    Command = SelectedButtonCommand
                });
            }
        }


        private ICommand _selectedButtonCommand;
        public ICommand SelectedButtonCommand
        {
            get
            {
                if (_selectedButtonCommand == null)
                    _selectedButtonCommand = new RelayCommand<ButtonDescription>(
                        o =>
                        {

                        }
                        );
                return SelectedButtonCommand;
            }
        }
    }
}
