using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ProcessingLayer;

namespace PresentationLayer
{
    public class ShowData: IShowData
    {
        private readonly IDataManager manager;
        public ShowData(IDataManager manager)
        {
            this.manager = manager;
        }
        public void showMeals(Dictionary<string, List<Dish>> meals)
        {
            foreach (var meal in meals)
            {
                Console.WriteLine(meal.Key);
                showMeals(meal.Value);
            }
        }
        public void showMeals<T>(List<T> meals)
        {
            foreach (var meal in meals)
            {
                Console.WriteLine(meal);
            }
        }
        public void showAllData()
        {
            Console.WriteLine("Brekfasts:");
            showMeals(manager.getBreakfasts());
            showMeals(manager.getEnglishBreakfastDishes());
            showMeals(manager.getFrenchBreakfastDishes());
            showMeals(manager.getGermanBreakfastDishes());
            showMeals(manager.getBreakfastIngredients());

            Console.WriteLine("Lunches:");
            showMeals(manager.getLunches());
            showMeals(manager.getLunch1Dishes());
            showMeals(manager.getLunch2Dishes());
            showMeals(manager.getLunch3Dishes());
            showMeals(manager.getLunchIngredients());

            Console.WriteLine("Dinners:");
            showMeals(manager.getDinners());
            showMeals(manager.getAsianDinnerDishes());
            showMeals(manager.getDinnerIngredients());
        }
    }
}
