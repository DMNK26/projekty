using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWPF;

namespace ClockWPFApp.ViewModels
{
    internal class StopWatchVM : ObserverVM
    {
        private bool isStopWatchRunning = false;

		private string _timeStorage;
		public string TimeStorage
		{
			get { return _timeStorage; }
			set 
            { 
                _timeStorage = value; 
                OnPropertyChanged(nameof(TimeStorage));
            }
		}

        private ICommand _startCommand;
        public ICommand StartCommand
        {
            get
            {
                if (_startCommand == null)
                    _startCommand = new RelayCommand<object>(
                        o =>
                        {
                            DateTime startTime = DateTime.Now;
                            isStopWatchRunning = true;
                            Task.Run(() =>
                            {
                                //int stopWatchMiliseconds = 0;
                                while (isStopWatchRunning)
                                {
                                    //stopWatchMiliseconds++;
                                    //TimeSpan timeSpan = TimeSpan.FromMilliseconds(stopWatchMiliseconds);
                                    //string stringTime = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
                                    TimeSpan timeSpan = DateTime.Now - startTime;
                                    string stringTime = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
                                    TimeStorage = stringTime;
                                    Thread.Sleep(1);
                                }
                            });
                        },
                        o => !isStopWatchRunning
                        );
                return _startCommand;
            }
        }

        private ICommand _stopCommand;
        public ICommand StopCommand
        {
            get
            {
                if (_stopCommand == null)
                    _stopCommand = new RelayCommand<object>(
                        o =>
                        {
                            isStopWatchRunning = false;
                        },
                        o => isStopWatchRunning
                        );
                return _stopCommand;
            }
        }
    }
}
