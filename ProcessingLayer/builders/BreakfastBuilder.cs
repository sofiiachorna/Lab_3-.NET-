﻿using ProcessingLayer.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace ProcessingLayer.builders
{
    public class BreakfastBuilder : IMealBuilder
    {
        private Breakfast breakfast;
        private readonly IData data;

        public BreakfastBuilder(IData data)
        {
            this.reset();
            this.data = data;
        }
        public BreakfastBuilder() 
        {
            this.reset();
        }

        public void addMealType(string type)
        {
            this.breakfast.Add(data.breakfasts[type]);
        }
        public void addDish(string type,string dishName)
        {
            List<Dish> datalist = new List<Dish>();
            if (type == "English breakfast")
            {
                datalist = data.EnglishBreakfastDishes;
            }
            if (type == "French breakfast")
            {
                datalist = data.FrenchBreakfastDishes;
            }
            if (type == "German breakfast")
            {
                datalist = data.GermanBreakfastDishes;
            }
            this.breakfast.Add(datalist.Find(item => item.Name == dishName));
        }
        public void addIngredient(string dish,List<string> ingredient)
        {
            this.breakfast.dishes.Find(item => item.Name.Equals(dish)).addIngredient(ingredient);
        }

        public void reset()
        {
            this.breakfast = new Breakfast();
        }
        public Order getResult() => this.breakfast;
    }
}
