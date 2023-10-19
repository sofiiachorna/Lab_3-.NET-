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
        public List<Dish> dishes { get; protected set; }
        public void Add(Dish dish)
        { dishes.Add(dish); }
        public void AddList(List<Dish> dishes)
        { this.dishes.AddRange(dishes); }
    }
}
