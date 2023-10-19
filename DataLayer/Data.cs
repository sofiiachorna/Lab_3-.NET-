using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Data : IData
    {
        public Dictionary<string, List<Dish>> breakfasts => new Dictionary<string, List<Dish>>()
        {
            {"English breakfast",
                new List<Dish>
                {
                    new Dish("Fried eggs",new List<string> {"egg"}),
                    new Dish("Bacon", new List<string> {"pork"}),
                    new Dish("Sausages", new List<string> {"pork"}),
                    new Dish("Tea", new List<string> {"milk"})
                }
                    
            },
            {"French breakfast", 
                new List<Dish>
                {
                    new Dish("Cereal",new List<string> {"oats"}),
                    new Dish("Gateau",new List<string>{"meat","cheese","mushrooms"})
                }
            },
            {"German breakfast",
                new List<Dish>
                {
                    new Dish("Sliced meats",new List<string>{"beef","ham"}),
                    new Dish("Bread with butter",new List<string>{"bread","butter"}),
                    new Dish("Potato omlet",new List<string>{"potato","eggs"}),
                    new Dish("Sliced cheese",new List<string>{"cheese"})
                }

            }
        };
        public List<Dish> EnglishBreakfastDishes => new List<Dish>
        {
            new Dish("Beans",new List<string>{"bean"}),
            new Dish("Jam",new List<string>{"berries"}),
            new Dish("Toast",new List<string>{"bread","butter"})
        };
        public List<Dish> FrenchBreakfastDishes => new List<Dish>
        {
            new Dish("Tartine",new List<string>{"bread","filling"}),
            new Dish("Croissant",new List<string>{"bread","filling"}),
            new Dish("Orange Juice",new List<string>{"orange"}),
            new Dish("Coffee",new List<string>{"coffee","sugar"}),
            new Dish("Tea",new List<string>{"tea","sugar"})
        };
        public List<Dish> GermanBreakfastDishes => new List<Dish>
        {
            new Dish("Fried egg",new List<string>{"egg"}),
            new Dish("Boiled egg",new List<string>{"egg"}),
            new Dish("Sausages",new List<string>{"beef","pork","chiken"}),
            new Dish("Coffee",new List<string>{"coffee","sugar"}),
            new Dish("Tea",new List<string>{"tea","sugar"})
        };
        public List<string> BreakfastIngredients => new List<string>
        {
            "Jam","Fresh vegetables","A bun with butter","Honey"
        };
        public Dictionary<string, List<Dish>> lunches => new Dictionary<string, List<Dish>>
        {
            { "Lunch #1",
                new List<Dish>
                {

                    new Dish("Ceasar salad",new List<string>{"chiken","eggs","tomatos","salad dressing"})
                }
            },
            { "Lunch #2",
                new List<Dish>
                {
                    new Dish("Mashed potato",new List<string>{"potato","butter"})
                    
                }

            },
            { "Lunch #3",
                new List<Dish>
                {
                    
                    new Dish("rice with beans",new List<string>{"rice","beans","sauce"})
                    
                }

            }
            
        };
        public List<Dish> Lunch1Dishes => new List<Dish>
        { 
            new Dish("Onion soup",new List<string>{"onions","potatos"}),
            new Dish("Pumpkin soup",new List<string>{"pumpkin","potatos"}),
            new Dish("Mushroom soup",new List<string>{"mushrooms","potatos"}),
            new Dish("Carbonara",new List<string>{"bacon","cheese"}),
            new Dish("Pasta with seafood",new List<string>{"shrimps","mussels"}),
            new Dish("Italian pasta",new List<string>{"tomato","cheese"}),
           
        };
        public List<Dish> Lunch2Dishes => new List<Dish>
        {
            new Dish("Beef steak",new List<string>{"beef","sauce"}),
            new Dish("Pork steak",new List<string>{"pork","sauce"}),
            new Dish("Tartare steak",new List<string>{"horsemeat","sauce"}),
            new Dish("Ceasar salad",new List<string>{"chiken","eggs","tomatos","salad dressing"}),
            new Dish("Greek salad",new List<string>{"tomato","olives","cheese","cucumbers"}),
            new Dish("Caprese salad",new List<string>{"tomato","mozzarella","basil"})
        };
        public List<Dish> Lunch3Dishes => new List<Dish>
        {
            new Dish("Baked dorado",new List<string>{"dorado","lemon","dressing"}),
            new Dish("Baked salmon",new List<string>{"salmon","lemon","dressing"}),
            new Dish("Baked perch",new List<string>{"perch","lemon","dressing"}),
            new Dish("Bruschetta with ham",new List<string>{"ham","cheese","greens"}),
            new Dish("Bruschetta with salmon",new List<string>{"salmon","sause","greens"}),
            new Dish("Bruschetta with cheese",new List<string>{"pear","cheese","honey"}),
        };
        public List<string> LunchIngredients => new List<string>
        {
            "creme","bread","sauce","croutons","tea","coffee","juice"
        };
        public Dictionary<string, List<Dish>> dinners => new Dictionary<string, List<Dish>>
        {
            {"Italian dinner",
                new List<Dish>
                {
                    new Dish("Lasagna",new List<string>{"meat","cheese","sauce"}),
                    new Dish("Tiramisu",new List<string>{"coffe","biscuits","creme"})
                } 
            },
            {"French dinner",
                new List<Dish>
                {
                    new Dish("Bouillabaisse",new List<string>{"fish","garlic"}),
                    new Dish("Escargot",new List<string>{"snails","filling"}),
                    new Dish("Chocolate souffle",new List<string>{"chocolate","filling"}),
                }
            },
            {"Asian dinner",
                new List<Dish>
                {
                    new Dish("Rolls",new List<string>{"fish","rice","nori"}),
                    new Dish("Noodles",new List<string>{"noodle","meat","greens"}),
                    new Dish("Mochi dessert",new List<string>{"rice dough","filling"})
                }
            }
        };
        public List<Dish> AsianDinnerDishes => new List<Dish>
        {
            new Dish("Phila Roll",new List<string>{"fish","rice","nori"}),
            new Dish("Futomaki Roll",new List<string>{"fish","rice","nori"}),
            new Dish("Veal noodles",new List<string>{"noodle","veal","greens"}),
            new Dish("Chiken noodles",new List<string>{"noodle","chiken","greens"}),
            new Dish("Tofu noodles",new List<string>{"noodle","tofu","greens"}),
            new Dish("Matcha mochi",new List<string>{"rice dough","matcha filling"}),
            new Dish("Raspberry mochi",new List<string>{"rice dough","raspberry filling"}),
            new Dish("Mango mochi",new List<string>{"rice dough","mango filling"})

        };
        public List<string> DinnerIngredients => new List<string>
        {
            "tomatoes","cucumbers","avocados","red wine","white wine","juice","tea","topping"
        };
    }
}