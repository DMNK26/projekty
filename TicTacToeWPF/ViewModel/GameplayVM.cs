using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;
using TicTacToeWPF.View;
using UtilitiesWPF;

namespace TicTacToeWPF.ViewModel
{
    internal class GameplayVM: ObserverVM
    {
        public ObservableCollection<FieldDescription> BoardList { get; set; }
       
        public GameplayVM()
        {
            BoardList = new ObservableCollection<FieldDescription>();
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 0,
                ColIndex = 0,
                RowIndex = 0,
                Command = SetCommand
                
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 1,
                RowIndex = 0,
                ColIndex = 1,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 2,
                RowIndex = 0,
                ColIndex = 2,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 3,
                RowIndex = 1,
                ColIndex = 0,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 4,
                RowIndex = 1,
                ColIndex = 1,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 5,
                RowIndex = 1,
                ColIndex = 2,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 6,
                RowIndex = 2,
                ColIndex = 0,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 7,
                RowIndex = 2,
                ColIndex = 1,
                Command = SetCommand
            });
            BoardList.Add(new FieldDescription()
            {
                Name = "",
                Index = 8,
                RowIndex = 2,
                ColIndex = 2,
                Command = SetCommand
                
            });
        }

        public bool currentPlayer = true;

        private int _scoreO = 0;
        public int ScoreO
        {
            get { return _scoreO; }
            set
            {
                _scoreO = value;
                OnPropertyChanged(nameof(ScoreO));
            }
        }

        private int _scoreX = 0;
        public int ScoreX
        {
            get { return _scoreX; }
            set
            {
                _scoreX = value;
                OnPropertyChanged(nameof(ScoreX));
            }
        }

        private ICommand _resetScoreCommand;
        public ICommand ResetScoreCommand
        {
            get
            {
                if (_resetScoreCommand == null)
                    _resetScoreCommand = new RelayCommand<object>(
                        o =>
                        {
                            ScoreO = 0;
                            ScoreX = 0;
                        }
                        );
                return _resetScoreCommand;
            }
        }


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

                            if (WinnerCheck())
                            {
                                MessageBox.Show(o.Name + " is a winner");
                                if (currentPlayer)
                                    ScoreO++;
                                else
                                    ScoreX++;

                                ResetBoard(o);
                            }
                            else
                            {
                                if (DrawCheck())
                                {
                                    MessageBox.Show("Remis");
                                    ResetBoard(o);
                                }   
                            }

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


        #region Winning Conditions

        private bool ButtonsInRow()
        {
            if ((BoardList[0].Name != "" && BoardList[0].Name == BoardList[1].Name && BoardList[1].Name == BoardList[2].Name) ||
                (BoardList[3].Name != "" && BoardList[3].Name == BoardList[4].Name && BoardList[4].Name == BoardList[5].Name) ||
                (BoardList[6].Name != "" && BoardList[6].Name == BoardList[7].Name && BoardList[7].Name == BoardList[8].Name))
                return true;
             else 
                return false;
        }

        private bool ButtonsInColumns()
        {
            if ((BoardList[0].Name != "" && BoardList[0].Name == BoardList[3].Name && BoardList[3].Name == BoardList[6].Name) ||
                (BoardList[1].Name != "" && BoardList[1].Name == BoardList[4].Name && BoardList[4].Name == BoardList[7].Name) ||
                (BoardList[2].Name != "" && BoardList[2].Name == BoardList[5].Name && BoardList[5].Name == BoardList[8].Name))
                return true;
            else
                return false;
        }

        private bool ButtonsInDiagonal()
        {
            if ((BoardList[0].Name != "" && BoardList[0].Name == BoardList[4].Name && BoardList[4].Name == BoardList[8].Name) ||
                (BoardList[2].Name != "" && BoardList[2].Name == BoardList[4].Name && BoardList[4].Name == BoardList[6].Name))
                return true;
            else
                return false;
        }

        public bool WinnerCheck()
        {
            if (ButtonsInRow() || ButtonsInColumns() || ButtonsInDiagonal())
                return true;
            else
                return false;
        }

        public bool DrawCheck()
        {
            return !BoardList.Any(o => o.Name == "");
        }
        #endregion

        private void ResetBoard(FieldDescription field)
        {
            for(int i = 0; i < BoardList.Count; i++)
            {
                field.Name = "";
                BoardList[i].Name = field.Name;
            }
        }
    }

}

