using LearningProject.Interfaces.MyExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes
{
    public class DragonTest : IFighterTest
    {
        public void Punch() 
        {
            Console.WriteLine("Дракон б'є хвостом");
        }
        public void Kick() 
        {
            Console.WriteLine("Дракон б'є лапою");
        }
        public void Block() 
        {
            Console.WriteLine("Дракон захищається");
        }

    }
}
