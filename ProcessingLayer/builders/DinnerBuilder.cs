using DataLayer;
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
        private readonly IData data;

        public DinnerBuilder(IData data)
        {
            this.reset();
            this.data = data;
        }
        public DinnerBuilder() { }

        public void addMealType(string type)
        {
            this.dinner.Add(data.dinners[type]);
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
    }
}
