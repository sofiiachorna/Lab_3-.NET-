using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer.products
{
    public class Order 
    {
        public List<Dish> dishes { get; }
        public void Add(Dish dish)
        { dishes.Add(dish); }
        public void Add(List<Dish> dishes)
        { dishes.AddRange(dishes); }
    }
}
