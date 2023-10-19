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
            Console.WriteLine("The Menu");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Brekfasts:");
            showMeals(manager.getBreakfasts());
            Console.WriteLine("Add to English breakfast:");
            showMeals(manager.getEnglishBreakfastDishes());
            Console.WriteLine("Add to French breakfast:");
            showMeals(manager.getFrenchBreakfastDishes());
            Console.WriteLine("Add to German breakfast:");
            showMeals(manager.getGermanBreakfastDishes());
            Console.WriteLine("You can add ingredients to breakfast:");
            showMeals(manager.getBreakfastIngredients());

            Console.WriteLine("Lunches:");
            showMeals(manager.getLunches());
            Console.WriteLine("Add to Lunch #1:");
            showMeals(manager.getLunch1Dishes());
            Console.WriteLine("Add to Lunch #2:");
            showMeals(manager.getLunch2Dishes());
            Console.WriteLine("Add to Lunch #3:");
            showMeals(manager.getLunch3Dishes());
            Console.WriteLine("You can add ingredients to lunch:");
            showMeals(manager.getLunchIngredients());

            Console.WriteLine("Dinners:");
            showMeals(manager.getDinners());
            Console.WriteLine("Add to Asian dinner:");
            showMeals(manager.getAsianDinnerDishes());
            Console.WriteLine("You can add ingredients to dinner:");
            showMeals(manager.getDinnerIngredients());
        }
    }
}
