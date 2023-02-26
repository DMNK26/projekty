using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TicTacToeWPF.Model;
using UtilitiesWPF;

namespace TicTacToeWPF.ViewModel
{
    internal class GameplayVM: ObserverVM
    {
        //start - pobiera combobox kto zaczyna
        public ObservableCollection<FieldDescription> BoardList { get; set; }

        private string _selectedPlayer;
        public string SelectedPlayer
        {
            get { return _selectedPlayer; }
            set
            {
                _selectedPlayer = value;
                OnPropertyChanged(nameof(SelectedPlayer));
            }
        }

        public GameplayVM()
        {
            BoardList = new ObservableCollection<FieldDescription>();
            BoardList.Add(new FieldDescription()
            {
                ColIndex = 0,
                RowIndex = 0,
                Command = SetCommand
                
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 0,
                ColIndex = 1,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 0,
                ColIndex = 2,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 1,
                ColIndex = 0,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 1,
                ColIndex = 1,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 1,
                ColIndex = 2,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 2,
                ColIndex = 0,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 2,
                ColIndex = 1,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                RowIndex = 2,
                ColIndex = 2,
                Command = SetCommand
                
            });
        }

        public bool currentPlayer = true;


        private ICommand _setCommand;
        public ICommand SetCommand
        {
            get
            {
                if (_setCommand == null)
                    _setCommand = new RelayCommand<FieldDescription>(
                        o =>
                        {
                            o.Name = currentPlayer ? "O" : "X";
                            currentPlayer = !currentPlayer;
                        }
                        ,
                        o =>
                        {
                            if (o?.Name != null && o?.Name != "")
                                return false;

                            return true;
                        });
                return _setCommand;
            }
        }
    }

    class FieldDescription : ObserverVM
    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        

        public ICommand Command { get; set; }
    }

}

