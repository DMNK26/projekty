using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UtilitiesWPF;

namespace OdliczanieWPF
{
    internal class CountdownVM : ObserverVM
    {
        DateTime endTime = new DateTime(2023, 6, 23, 10, 0, 0);
        DateTime currentTime = new DateTime();


        private string _time;
        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public CountdownVM()
        {
            currentTime = DateTime.Now;

            Task task = new Task(() =>
            {
                while (true)
                {
                    currentTime = DateTime.Now;
                    Thread.Sleep(1000);
                    TimeSpan interval = endTime - currentTime;
                    Time = "Dni: "+interval.Days + " Godzin: "+interval.Hours + " Minut: "+interval.Minutes + " Sekund: "+interval.Seconds;
                }

            });
            task.Start();
        }


    }
}

