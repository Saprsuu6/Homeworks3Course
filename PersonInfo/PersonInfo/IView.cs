using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfo
{
    interface IView
    {
        string GetSetSurname { set; get; }
        string GetSetName { set; get; }
        string GetSetPatronimic { set; get; }
        bool GetSetMen { set; get; }
        bool GetSetWomen { set; get; }
        DateTime GetSetBirthday { set; get; }
        bool GetSetStatusWithFamaly { set; get; }
        bool GetSetStatusWithoutFamaly { set; get; }
        string GetSetInfo { set; get; }
    }
}
