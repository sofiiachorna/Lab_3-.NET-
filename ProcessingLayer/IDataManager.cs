using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public interface IDataManager
    {
        Dictionary<string, List<Dish>> getBreakfasts();
        Dictionary<string, List<Dish>> getLunches();
        Dictionary<string, List<Dish>> getDinners();
       List<Dish> getEnglishBreakfastDishes();
        List<Dish> getFrenchBreakfastDishes();
        List<Dish> getGermanBreakfastDishes();
        List<string> getBreakfastIngredients();
       List<Dish> getLunch1Dishes(); 
       List<Dish> getLunch2Dishes();
        List<Dish> getLunch3Dishes();
        List<string> getLunchIngredients();
        List<Dish> getAsianDinnerDishes();
        List<string> getDinnerIngredients();
    }
}
