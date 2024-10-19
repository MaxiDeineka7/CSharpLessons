using LearningProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes
{
    public class Soldier : IFighter
    {
        public void Punch()
        {
            Console.WriteLine("Soldier punch!");
        }

        public void Kick()
        {
            Console.WriteLine("Soldier kick!");
        }

        public void Block()
        {
            Console.WriteLine("Soldier defend!");
        }
    }

        class Dragon : IFighter
    {
        public void Punch()
        {
            Console.WriteLine("Dragon punch!");
        }

        public void Kick()
        {
            Console.WriteLine("Dragon kick!");
        }

        public void Block()
        {
            Console.WriteLine("Dragon defend!");
        }
    }
}
