using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ProcessingLayer
{
    public class Director : IDirector
    {
        private IMealBuilder _mealBuilder;
        public void setBuilder(IMealBuilder builder)
        {
            this._mealBuilder = builder;
        }
        public void createOrder(string type)
        {
            _mealBuilder.addMealType(type);
        }
        public void createOrder(string type, List<string> dishes)
        {
            createOrder(type);
            foreach (var dish in dishes)
            {
                _mealBuilder.addDish(type, dish);
            }

        }
        public void createOrder(string type, List<string> dishes, List<List<string>> Ingredients)
        {
            createOrder(type, dishes);
            for (int i = 0; i < dishes.Count; i++)
            {
                _mealBuilder.addIngredient(dishes[i], Ingredients[i]);
            }

        }
    }
}
