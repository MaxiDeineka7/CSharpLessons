using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Interfaces
{
    interface INewInterfaceTest
    {
        string Method();

        float this[int index] { get; set; }

        string Name { get; set; }
        
        event EventHandler<EventArgs> MethodChanged;
    }
}
