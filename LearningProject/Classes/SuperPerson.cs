using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes
{
    class SuperPerson : Person
    {
        string SuperPower;

        public SuperPerson(string name, double salary, int birthYear, string superPower) : base(name, salary, birthYear, 255)
        {
            this.SuperPower = superPower;
        }
    }
}
