using LearningProject.Classes;
using System;
using System.Collections.Generic;

namespace LearningProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Порада: Коментуйте кожен регіон, який вам на разі не потрібен для виконання

            #region Основа та Змінні
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!"); // вивід в консоль
            Console.ReadLine(); // очікування вводу від користувача
            Console.WriteLine();

            // - однорядковий коментар
            /* - багаторядковий коментар
             * 
             */

            // тип_даних ім'я змінної;
            // назва змінної - починається з літери або _
            // може містити будь-які символи, цифри та знак _

            string address;
            int value;
            int Value = 10;
            int myFirstValue;
            value = 5;
            Value = 5;
            Console.WriteLine(value);
            int a = 5;
            int b = 10;
            int result = a + b;
            Console.WriteLine(result);

            // System.Boolean, bool
            bool f = false;

            //System.Byte, byte 0 до 255
            byte b1 = 222;
            System.Byte b2 = 222;

            //System.SByte, sbyte -128 до 127
            //float 
            b1 = byte.MinValue;

            //char - символ ''
            //string - рядок ""

            //object - базовий тип
            object o1 = 454;
            object o2 = "H";
            object o3 = 'H';

            var k = 4;

            //Літерали
            //true false
            //Двійкові (бінарні)
            //0b
            //0b00000100
            //Вісімкові
            //x=0125
            //Шістнадцяткові
            //0 1 2 3 4 5 6 7 8 9 A B C D E F 10 11 19 1A 1B 1F 20 2F 30 
            //0x12, 0xFF, 0xFDA54
            //Дійсні
            //5.25 або 2.34e6=2.34*10^6
            //2.73e-3 = 2.73*10^-3=0.00273
            //Escape-послідовності
            //\n - новий рядок 
            //\t - табуляція
            //\' - апостроф
            //\" - подвійні лапки

            //Арифметичні операції
            //+
            //-
            //*
            // /
            // % - остача від ділення
            // ++ - інкремент
            // -- - декремент
            int x = 10;
            x++;

            //Префіксна форма запису
            int a1 = 5;
            int b11 = ++a1;
            //Результат: a1=6, b11=6
            //Постфіксна форма запису
            int a12 = 5;
            int b111 = a12++;
            //Результат: a12=6, b111=5

            //Оголошення змінної та ініціалізація змінної
            int p, s, q; //оголошення змінної
            p = 14; //ініціалізація
            p = s = q = 100;
            //Складені оператори присвоєння
            //+=
            //-=
            //*=
            ///=
            //%=
            p += 10; //p=p+10;
                     //Умовні вирази
                     // ==
                     // !=
                     // >
                     // <
                     // >=
                     // <=
            byte x1 = 1;
            byte y1 = 3;
            bool w = x1 >= y1; // false
            bool w1 = x1 <= y1; // true
            #endregion

            #region Логічні оператори
            //Оператор логічного заперечення - !
            bool w2 = !w1; //false
                           //Оператор логічного додавання (диз'юнкція) (логічне або)
                           // | - повна диз'юнкція
                           // || - скорочене логічне додавання

            bool b3 = (2 > 5) | (1 > 2); // false тому що, (2 > 5) - false, (1 > 2) - false
            bool c = (2 < 5) | (1 < 2); // true тому що, (2 < 5) - true, (1 > 2) - false
            bool d = (2 < 5) || (1 < 2); // true, оскільки (2 < 5) - true, то другий операнд не обчислюється

            //Оператор логічного множення (кон'юнкція) (логічне і)
            // & - повна кон'юнкція
            // && - скорочене логічне множення

            bool a7 = (2 < 5) & (1 < 2); // true тому що, (2 < 5) - true, (1 < 2) - true
            bool b7 = (2 < 5) & (1 > 2); // false тому що, (2 < 5) - true, (1 > 2) - false
            bool c7 = (1 > 4) && (1 < 2); // false, оскільки (1 > 4) - false, то другий операнд (1 < 2) не обчислюється

            //Оператор логічного додавання за модулем ^ (xor)
            bool a8 = (3 < 6) ^ (4 < 8); //false, обидва true
            bool b9 = (2 < 5) ^ (1 > 2); //true

            if (5 > 2)
            {
                d = (3 > 5) | (4 > 5);
                b9 = (4 > 5) & (1 > 2);
            }
            else
            {
                a = 44;
            }
            #endregion

            #region Класи та Успадкування
            Person p1 = new Person();
            Person p2 = new Person("Petro");
            Person p3 = new Person("Petro", 555);
            Person p4 = new Person("Petro", 555, 2024, 2.5);
            p1.Name = "dfsfs";
            p1.Salary = -1000;
            p1.Add(3, 4);
            int r = p1.Add(1, 2, 3);
            Console.WriteLine(p1.GetInformation());
            p1.PrintInformation();
            int i = 0;
            Person.bonus += 300;

            #endregion

            #region Інтерфейси
            //SoldierTest fighter = new SoldierTest();
            //fighter.Kick();
            //fighter.Block();
            //fighter.Punch();

            //Dragon dragon = new Dragon();
            //dragon.Kick();
            //dragon.Block();
            //dragon.Punch();



            //// IEnumerable
            //var collection = new CustomCollection();
            //collection.Add(1);
            //collection.Add(2);
            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            //// IComparable
            //List<Person> people = new List<Person>
            //{
            //    new Person { Name = "Alice", Age = 30 },
            //    new Person { Name = "Bob", Age = 25 },
            //    new Person { Name = "Charlie", Age = 35 }
            //};

            //people.Sort();

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.Name}: {person.Age}");
            //}

            //// IDisposable
            //using (var resource = new ResourceHolder())
            //{
            //    data = 1;
            //}


            // ICollection
            //var customCollection = new CustomCollection();
            //customCollection.Add(3);
            //customCollection.Add(5);
            //bool exists = customCollection.Contains(3);


            #endregion

            #region Колекції
            //ПРИКЛАДИ З ПАРИ

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //numbers.Add(6);
            ////numbers.Remove(1);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int first = numbers[2];

            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[0]);

            //Dictionary<string, int> ages = new Dictionary<string, int>();
            //ages.Add("Alice", 30);
            //ages.Add("Bob", 25);
            //int aliceAge = ages["Alice"];

            //Console.WriteLine();


            //HashSet<string> fruits = new HashSet<string>();
            //fruits.Add("Apple");
            //fruits.Add("Banana");
            //fruits.Add("Apple"); // Помилка
            //fruits.Clear()

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("First");
            //queue.Enqueue("Second");
            //queue.Enqueue("Third");
            //queue.Enqueue("Fourth");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //string firstInQueue = queue.Dequeue(); // Вилучає перший елемент

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //int lastInStack = stack.Pop(); // - останній елемент

            //ІНШІ ПРИКЛАДИ ДЛЯ РОЗУМІННЯ

            /////////////////List
            List<Order> orders = new List<Order>
            {
                new Order("Pizza", 2),
                new Order("Burger", 3),
                new Order("Pasta", 1)
            };

            orders.Add(new Order("Salad", 2)); // Додаємо нове замовлення

            foreach (var order in orders)
            {
                Console.WriteLine($"Dish: {order.DishName}, Quantity: {order.Quantity}");
            }

            // Виведення:
            /*  Dish: Pizza, Quantity: 2
                Dish: Burger, Quantity: 3
                Dish: Pasta, Quantity: 1
                Dish: Salad, Quantity: 2  */

            /////////////////Dictionary
            Dictionary<int, BankClient> clients = new Dictionary<int, BankClient>();

            // Додаємо кілька клієнтів
            clients.Add(101, new BankClient(101, "Олег Іванов", 1200.50m));
            clients.Add(102, new BankClient(102, "Марія Петрова", 2300.75m));
            clients.Add(103, new BankClient(103, "Іван Коваленко", 1500.00m));

            // Перевіряємо, чи є клієнт з конкретним ID
            int Id = 102;
            if (clients.ContainsKey(Id))
            {
                Console.WriteLine($"Клієнт з ID {Id}: {clients[Id]}");
            }
            else
            {
                Console.WriteLine($"Клієнт з ID {Id} не знайдений.");
            }

            // Виведення:
            /*Клієнт з ID 102: ID: 102, Name: Марія Петрова, Balance: 2300.75*/


            /////////////////HashSet
            HashSet<string> uniqueOrders = new HashSet<string>();

            uniqueOrders.Add("Pizza");
            uniqueOrders.Add("Burger");
            uniqueOrders.Add("Pizza"); // Дублікат не додається
            uniqueOrders.Add("Salad");

            foreach (var dish in uniqueOrders)
            {
                Console.WriteLine(dish);
            }

            // Виведення:
            /*  Pizza
                Burger
                Salad  */


            /////////////////Queue
            Queue<string> orderQueue = new Queue<string>();

            orderQueue.Enqueue("Pizza");
            orderQueue.Enqueue("Burger");
            orderQueue.Enqueue("Pasta");

            Console.WriteLine("Serving orders:");

            while (orderQueue.Count > 0)
            {
                Console.WriteLine($"Serving: {orderQueue.Dequeue()}");
            }

            // Виведення:
            /*  Serving orders:
                Serving: Pizza
                Serving: Burger
                Serving: Pasta  */

            /////////////////Stack
            Stack<string> orderStack = new Stack<string>();

            orderStack.Push("Pizza");
            orderStack.Push("Burger");
            orderStack.Push("Pasta");

            Console.WriteLine("Serving last-minute changes:");

            while (orderStack.Count > 0)
            {
                Console.WriteLine($"Serving: {orderStack.Pop()}");
            }

            // Виведення:
            /*  Serving last-minute changes:
                Serving: Pasta
                Serving: Burger
                Serving: Pizza  */
            #endregion

            Console.ReadKey();
        }
    }
}
