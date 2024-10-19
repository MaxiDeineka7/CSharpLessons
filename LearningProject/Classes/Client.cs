using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes
{
    public class BankClient
    {
        public int ID { get; set; }         // Ідентифікаційний код клієнта
        public string Name { get; set; }    // Ім'я клієнта
        public decimal Balance { get; set; } // Баланс клієнта на рахунку

        public BankClient(int id, string name, decimal balance)
        {
            ID = id;
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Balance: {Balance:C}";
        }
    }
}
