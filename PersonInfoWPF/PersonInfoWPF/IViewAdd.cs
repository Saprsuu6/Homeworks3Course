using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PersonInfoWPF
{
    interface IViewAdd : IView
    {
        public Window GetWindow { get; }
        public Button GetRemove { get; }
        public Button GetEdit { get; }
        public ListBox listBox { get; }
        public Image GetSavePersons { get; }

        event EventHandler<EventArgs> dataRemove;
        event EventHandler<EventArgs> dataSave;
        event EventHandler<EventArgs> dataSaveInFile;
        event EventHandler<EventArgs> dataEdit;
    }
}
