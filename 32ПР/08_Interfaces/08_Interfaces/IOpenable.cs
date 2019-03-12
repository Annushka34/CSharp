using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    interface IOpenable
    {
        bool IsOpen { get; set; }
        void Open();
        void Close();
    }
}
