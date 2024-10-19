using LearningProject.Interfaces.MyExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes.MyExamples
{
    public class SoldierTest: IFighterTest
    {
        public void Punch() 
        {
            Console.WriteLine("Солдат б'є мечем");
        }

        public void Kick() 
        {
            Console.WriteLine("Солдат б'є ногою");
        }

        public void Block()
        {
            Console.WriteLine("Солдат захищається");
        }
    }
}
