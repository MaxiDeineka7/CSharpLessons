using System;

namespace LearningProject.Abstract_Classes
{

    interface IRepairable
    {
        void Repaire();
    }

    interface IRozborka
    {
        void Check();
    }

    abstract class Vehicle : IRozborka, IComparable<Vehicle>
    {
        public string Name = "ffrfr";

        public abstract string Model { get; set; }

        public abstract void Move();

        public abstract void Check();

        public void Sound()
        {
            Console.WriteLine(" Подати сигнал!");
        }

        //Реалізація інтерфейсу IComparable
        public int CompareTo(Vehicle other)
        {
            if (other == null) return 1;
            return Model.CompareTo(other.Model); // Порівняння за Моделлю
        }
    }

    class Car : Vehicle, IRepairable
    {
        public override string Model { get; set; }

        public override void Move()
        {
            Console.WriteLine(" Настискаємо педаль газу!");
        }

        public override void Check()
        {
            Console.WriteLine(" Перевіряємо чи розкладається Машина!");
        }

        public void Repaire()
        {
            Console.WriteLine(" Ремонтуємо машину.");
        }
    }

    class Bicycle : Vehicle, IRepairable
    {
        public override string Model { get; set; }

        public override void Move()
        {
            Console.WriteLine(" Крутимо педалі!");
        }

        public override void Check()
        {
            Console.WriteLine(" Перевіряємо чи розкладається Велосипед!");
        }

        public void Repaire()
        {
            Console.WriteLine(" Ремонтуємо велосипед.");
        }
    }

    class Plane : Vehicle
    {
        public override string Model { get; set; }

        public override void Check()
        {
            Console.WriteLine(" Перевіряємо чи розкладається Літак!");
        }

        public override void Move()
        {
            Console.WriteLine(" Тягнемо штурвал!");
        }
    }
}
