using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ToDoListApp
{
    class ToDoTasc : BindableObject
    {
        public string TaskDesc { get; set; }
        public string IsEnded { get; set; }
    }
}
