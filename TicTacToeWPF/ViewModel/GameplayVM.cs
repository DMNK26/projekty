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
    internal class GameplayVM : ObserverVM
    {
        public ObservableCollection<FieldDescription> BoardList { get; set; }

        private int _columnCount = 3;
        public int ColumnCount
        {
            get { return _columnCount; }
            set
            {
                _columnCount = value;
                OnPropertyChanged(nameof(ColumnCount));
            }
        }


        private int _rowCount = 3;
        public int RowCount
        {
            get { return _rowCount; }
            set
            {
                _rowCount = value;
                OnPropertyChanged(nameof(RowCount));
            }
        }

        public GameplayVM()
        {
            BoardList = new ObservableCollection<FieldDescription>();
            int i = 0;
            for (int c = 0; c < ColumnCount; c++)
            {
                int r = 0;
                do
                {
                    BoardList.Add(new FieldDescription()
                    {
                        Name = "",
                        Index = i,
                        RowIndex = r,
                        ColIndex = c,
                        Command = SetCommand
                    });
                    r++;
                    i++;
                } while (r != ColumnCount);
            }          
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
                            CurrentPlayerTextBlock = !currentPlayer ? "O" + " move" : "X" + " move";
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
                                    MessageBox.Show("Draw");
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

        private string _currentPlayerTextBlock = "O move";
        public string CurrentPlayerTextBlock
        {
            get { return _currentPlayerTextBlock; }
            set
            {
                _currentPlayerTextBlock = value;
                OnPropertyChanged(nameof(CurrentPlayerTextBlock));
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

            //for (int i = 0; i < RowCount; i++)
            //{
            //    IEnumerable<string> query = (IEnumerable<string>)BoardList.Where(o =>o.Name != "" && o.RowIndex == i && o.Name.Equals(currentPlayer));
            //    int elements = query.Count();
            //    if (elements == 3)
            //    {
            //        return true;
            //    }
            //    else
            //        continue;
            //}
            //return false;
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
            for (int i = 0; i < BoardList.Count; i++)
            {
                field.Name = "";
                BoardList[i].Name = field.Name;
            }
        }

        private ICommand _resetBoardCommand;
        public ICommand ResetBoardCommand
        {
            get
            {
                if (_resetBoardCommand == null)
                    _resetBoardCommand = new RelayCommand<object>(
                        o =>
                        {
                            for (int i = 0; i < BoardList.Count; i++)
                            {
                                BoardList[i].Name = "";
                                continue;
                            }
                        }
                        );
                return _resetBoardCommand;
            }
        }
    }
}

