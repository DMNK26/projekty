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
        public ObservableCollection<ToDoTasc> TasksCollection { get; set; }
        public ObservableCollection<ToDoTasc> DeletedTasksCollection { get; set; }


        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value;
                OnPropertyChanged();
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
                            ToDoTasc thisTask = new ToDoTasc();
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
                    _deleteTaskCommand = new Command<ToDoTasc>(
                        o =>
                        {
                            ToDoTasc deleteTask = new ToDoTasc();
                            //DeletedDescription = o.TaskDesc;
                            deleteTask.TaskDesc = o.TaskDesc;
                            //DeletedSelectedValueRadio = o.IsEnded;
                            deleteTask.IsEnded = o.IsEnded;
                            if (deleteTask.IsEnded == null)
                                deleteTask.IsEnded = "Nie zaznaczono";
                            DeletedTasksCollection.Add(deleteTask);
                            TasksCollection.Remove(o);
                        }
                        );
                return _deleteTaskCommand;
            }
        }

        public MainVM()
        {
            TasksCollection = new ObservableCollection<ToDoTasc>();
            DeletedTasksCollection = new ObservableCollection<ToDoTasc>();
        }
	}
}
