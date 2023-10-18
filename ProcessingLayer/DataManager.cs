using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public class DataManager : IDataManager
    {
        private readonly IData data;
        public DataManager(IData data)
        { this.data = data; }
        public Dictionary<string, List<Dish>> getBreakfasts() =>  data.breakfasts;
        
        public Dictionary<string, List<Dish>> getLunches() => data.lunches; 
        public Dictionary<string,List<Dish>> getDinners() => data.dinners;
        public List<Dish> getEnglishBreakfastDishes() => data.EnglishBreakfastDishes;
        public List<Dish> getFrenchBreakfastDishes() => data.FrenchBreakfastDishes;
        public List<Dish> getGermanBreakfastDishes() => data.GermanBreakfastDishes;
        public List<string> getBreakfastIngredients() => data.BreakfastIngredients;
        public List<Dish> getLunch1Dishes() => data.Lunch1Dishes;
        public List<Dish> getLunch2Dishes() => data.Lunch2Dishes;
        public List<Dish> getLunch3Dishes() => data.Lunch3Dishes;
        public List<string> getLunchIngredients() => data.LunchIngredients;
        public List<Dish> getAsianDinnerDishes() => data.AsianDinnerDishes;
        public List<string> getDinnerIngredients() => data.DinnerIngredients;
    }
}
