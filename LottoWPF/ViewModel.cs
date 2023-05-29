using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWPF;

namespace LottoWPF
{
    internal class ViewModel
    {
        private int min = 1;
        private int max = 49;
        public ObservableCollection<int> DrawnNumbers { get; set; } = new ObservableCollection<int>();
        private int numbersCount = 6;

        private ICommand _drawnNumbersCommand;
        public ICommand DrawnNumbersCommand
        {
            get
            {
                if (_drawnNumbersCommand == null)
                    _drawnNumbersCommand = new RelayCommand<object>(
                        o =>
                        {
                            Random random = new Random();
                            DrawnNumbers.Clear();

                            var drawNumbers = Enumerable.Range(min, max - min + 1)
                                                        .OrderBy(x => random.Next())
                                                        .Take(numbersCount);

                            foreach(var item in drawNumbers)
                            {
                                DrawnNumbers.Add(item);
                            }
                        }
                        );
                return _drawnNumbersCommand;
            }
        }
    }
}
