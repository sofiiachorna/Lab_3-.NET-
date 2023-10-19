using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using ProcessingLayer.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public class LunchBuilder : IMealBuilder
    {
        private Lunch lunch;
        private IData data;

        public LunchBuilder() 
        { 
            this.reset();
        }

        public void addMealType(string type)
        {
            this.lunch.AddList(data.lunches[type]);
        }
        public void addDish(string type, string dishName)
        {
            List<Dish> datalist = new List<Dish>();
            if (type == "Lunch #1")
            {
                datalist = data.Lunch1Dishes;
            }
            if (type == "Lunch #2")
            {
                datalist = data.Lunch2Dishes;
            }
            if (type == "Lunch #3")
            {
                datalist = data.Lunch3Dishes;
            }
            this.lunch.Add(datalist.Find(item => item.Name == dishName));
        }
        public void addIngredient(string dish, List<string> ingredient)
        {
            this.lunch.dishes.Find(item => item.Name.Equals(dish)).addIngredient(ingredient);
        }

        public void reset()
        {
            this.lunch = new Lunch();
        }
        public Order getResult() => this.lunch;

        public void setData(IData data)
        {
            this.data = data;
        }
    }
}
