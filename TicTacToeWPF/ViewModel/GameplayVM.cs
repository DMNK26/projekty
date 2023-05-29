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
            for(int i = 0; i < RowCount; i++)
            {
                for(int j = 0; j < ColumnCount; j++)
                {
                    BoardList.Add(new FieldDescription()
                    {
                        Name = "",
                        RowIndex = i,
                        ColIndex = j,
                        Command = SetCommand
                    });
                }
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
        
        private string CurrentPlayerString()
        {
            if (currentPlayer)
                return "O";

            return "X";
        }

        private bool ButtonsInRow()
        {
            var query = BoardList.GroupBy(row => row.RowIndex);
            foreach(var collection in query)
            {
                if (collection.All(o => o.Name == CurrentPlayerString()))
                    return true;
                
                
            }
            return false;
        }

        private bool ButtonsInColumns()
        {
            var query = BoardList.GroupBy(row => row.ColIndex);
            foreach (var collection in query)
            {
                if (collection.All(o => o.Name == CurrentPlayerString()))
                    return true;


            }
            return false;
        }

        private bool ButtonsInCrossLR()
        {
            var query = BoardList.Where(cross => cross.RowIndex == cross.ColIndex);
            if (query.All(o => o.Name == CurrentPlayerString()))
            { 
                return true; 
            }

            return false;
        }

        private bool ButtonsInCrossRL()
        {
            var query = BoardList.Where(cross => cross.ColIndex == (RowCount - cross.RowIndex - 1));
            if (query.All(o => o.Name == CurrentPlayerString()))
            {
                return true;
            }

            return false;
        }

        public bool WinnerCheck()
        {
            if (ButtonsInRow() || ButtonsInColumns() || ButtonsInCrossLR() || ButtonsInCrossRL())
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

