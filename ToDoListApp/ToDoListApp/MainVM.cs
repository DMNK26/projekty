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
            set { _description = value; }
        }

        private string _deletedDescription;
        public string DeletedDescription
        {
            get { return _deletedDescription; }
            set { _deletedDescription = value; }
        }

        private string _deletedSelectedValueRadio;
        public string DeletedSelectedValueRadio
        {
            get { return _deletedSelectedValueRadio; }
            set { _deletedSelectedValueRadio = value; }
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


        private ICommand _deleteTaskCommand;
        public ICommand DeleteTaskCommand
        {
            get
            {
                if (_deleteTaskCommand == null)
                    _deleteTaskCommand = new Command<Task>(
                        o =>
                        {
                            Task deleteTask = new Task();
                            DeletedDescription = o.TaskDesc;
                            DeletedSelectedValueRadio = o.IsEnded;
                            if (DeletedSelectedValueRadio == null)
                                DeletedSelectedValueRadio = "Nie zaznaczono";
                            DeletedTasksCollection.Add(deleteTask);
                            TasksCollection.Remove(o);
                        }
                        );
                return _deleteTaskCommand;
            }
        }

        public MainVM()
        {
            TasksCollection = new ObservableCollection<Task>();
            DeletedTasksCollection = new ObservableCollection<Task>();
        }
	}
}
