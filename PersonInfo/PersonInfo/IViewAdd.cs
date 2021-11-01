using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfo
{
    interface IViewAdd : IView
    {
        public Button GetRemove { get; }
        public ListBox listBox { get; }
        public ToolStripButton Button { get; }

        event EventHandler<EventArgs> dataRemove;
        event EventHandler<EventArgs> dataSave;
        event EventHandler<EventArgs> dataSaveInFile;
        event EventHandler<EventArgs> dataEdit;
    }
}
