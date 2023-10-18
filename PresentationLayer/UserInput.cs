using DataLayer;
using ProcessingLayer;
using ProcessingLayer.builders;
using System.Collections.Generic;

namespace PresentationLayer
{
    public class UserInput : IUserInput
    {
        private readonly IDirector director;
        private readonly IShowData showData;
        private readonly IOrderOutput orderOutput;
        public UserInput (IDirector director, IShowData showData, IOrderOutput orderOutput)
        {
            this.director = director;
            this.showData = showData;
            this.orderOutput = orderOutput; 
        }
        public void makeOrder()
        {
            List<string> dishes = new List<string> ();
            List<List<string>> ingredients = new List<List<string>> ();

            showData.showAllData();
            Console.WriteLine("What do you want to order?\n" +
                " 1.Breakfast\n 2.Lunch\n 3.Dinner");
           int choice = int.Parse(Console.ReadLine());
            GetBuilder(choice);
            Console.WriteLine("Choose a menu:");
            string type = Console.ReadLine();
            Console.WriteLine("Do you want to add any dishes?");
            string d = Console.ReadLine();
            if(d =="yes")
            {
                string answer = "yes";
                while(answer == "yes")
                {
                    List<string> components = new List<string>();
                    Console.WriteLine("Choose a dish:");
                    string dishName = Console.ReadLine();
                    dishes.Add(dishName);
                    Console.WriteLine("Do you want to add any ingredients to the dish?");
                    string i = Console.ReadLine();
                    if(i == "yes")
                    {
                        string ings = Console.ReadLine();
                        components.AddRange(ings.Split(", "));

                    }
                    ingredients.Add(components);
                    Console.WriteLine("Add another dish?");
                    answer = Console.ReadLine();
                    
                }
                director.createOrder(type,dishes,ingredients);
            }
            else 
            {
                director.createOrder(type);
            }
            orderOutput.showOrder();
        }
        private void GetBuilder(int choice)
        {
            switch(choice) 
            {
                case 1:
                    director.setBuilder(new BreakfastBuilder());

                    break;
                case 2:
                    director.setBuilder(new LunchBuilder());
                    break;
                case 3:
                    director.setBuilder(new DinnerBuilder());
                    break;
                default:
                    Console.WriteLine("Choose a valid option.");
                    break;

            }
        }
       
    }
}