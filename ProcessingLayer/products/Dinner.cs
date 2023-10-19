using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer.products
{
    public class Dinner: Order
    {
        public Dinner()
        {
            dishes = new List<Dish>();
        }
        public override string ToString()
        {
            return $"Вечеря:\n{string.Join(" \n", this.dishes)}";
        }
    }
}
