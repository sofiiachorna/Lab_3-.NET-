using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ProcessingLayer.products
{
    public  class Breakfast : Order
    {
        public Breakfast() 
        {
            dishes = new List<Dish>();
        }
        public override string ToString()
        {
            return $"Сніданок:\n{string.Join(" \n", dishes)}";
        }
    }
}
