using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TicTacToeWPF.ViewModel
{
    internal class GameplayVM
    {
		//start - pobiera combobox kto zaczyna
		private ICommand _startCommand;
		public ICommand StartCommand
		{
			get { return _startCommand; }
			set { _startCommand = value; }
		}

	}
}
