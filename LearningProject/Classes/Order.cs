﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes
{
    public class Order
    {
        public string DishName { get; set; }
        public int Quantity { get; set; }

        public Order(string dishName, int quantity)
        {
            DishName = dishName;
            Quantity = quantity;
        }
    }
}
