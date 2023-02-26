using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ToDoListApp
{
    class Task : BindableObject
    {
        public string TaskDesc { get; set; }
        public bool IsEnded { get; set; }
    }
}
