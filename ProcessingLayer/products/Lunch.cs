using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer.products
{
    public class Lunch : Order
    {
        public Lunch()
        {
            dishes = new List<Dish>();
        }
        public override string ToString()
        {
            return $"Обід:\n{string.Join(" \n", this.dishes)}";
        }
    }
}
