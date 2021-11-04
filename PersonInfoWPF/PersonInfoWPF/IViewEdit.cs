using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoWPF
{
    interface IViewEdit : IView
    {
        event EventHandler<EventArgs> dataSaveEdit;
    }
}
