using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IData
    {
        Dictionary<string, List<Dish>> breakfasts { get; }
        List<Dish> EnglishBreakfastDishes { get; }
               
        List<Dish> FrenchBreakfastDishes { get;}
             
        List<Dish> GermanBreakfastDishes { get; }
              
        List<string> BreakfastIngredients { get;}
              
        Dictionary<string, List<Dish>> lunches { get;}
                
        List<Dish> Lunch1Dishes { get; }
              
        List<Dish> Lunch2Dishes { get; }
              
        List<Dish> Lunch3Dishes { get; }
                
        List<string> LunchIngredients { get; }
                
        Dictionary<string, List<Dish>> dinners { get; }
        List<Dish> AsianDinnerDishes { get; }
        List<string> DinnerIngredients { get; }


    }
}
