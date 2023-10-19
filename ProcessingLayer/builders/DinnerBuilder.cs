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
    public class DinnerBuilder : IMealBuilder
    {
        private Dinner dinner;
        private IData data;

        public DinnerBuilder() 
        {
            this.reset();
        }

        public void addMealType(string type)
        {
            this.dinner.AddList(data.dinners[type]);
        }
        public void addDish(string type, string dishName)
        {
            List<Dish> datalist = new List<Dish>();
            if (type == "Asian dinner")
            {
                datalist = data.AsianDinnerDishes;
            }
            this.dinner.Add(datalist.Find(item => item.Name == dishName));
        }
        public void addIngredient(string dish, List<string> ingredient)
        {
            this.dinner.dishes.Find(item => item.Name.Equals(dish)).addIngredient(ingredient);
        }

        public void reset()
        {
            this.dinner = new Dinner();
        }
        public Order getResult() => this.dinner;

        public void setData(IData data)
        {
            this.data = data;
        }
    }
}
