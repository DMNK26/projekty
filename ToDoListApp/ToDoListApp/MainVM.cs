using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace ToDoListApp
{
    internal class MainVM : BindableObject
    {
        public ObservableCollection<Task> TasksCollection { get; set; }
        public ObservableCollection<Task> DeletedTasksCollection { get; set; }


        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        private ICommand _addNewTaskCommand;
        public ICommand AddNewTaskCommand
        {
            get
            {
                if (_addNewTaskCommand == null)
                    _addNewTaskCommand = new Command<object>(
                        o =>
                        {
                            Task thisTask = new Task();
                            thisTask.TaskDesc = Description;
                            TasksCollection.Add(thisTask);
                        }
                        );
                return _addNewTaskCommand;
            }
        }

        public MainVM()
        {
            TasksCollection = new ObservableCollection<Task>();
        }
	}
}
