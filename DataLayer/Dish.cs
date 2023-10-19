using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Dish
    {
        public string Name { get; }
        public List<string> Ingredients { get; }
        public Dish(string Name, List<string> Ingredients) 
        { 
            this.Name = Name;
            this.Ingredients = Ingredients;
        }
        public void addIngredient(string Ingredient) 
        { 
            Ingredients.Add(Ingredient);
        }
        public void addIngredient(List<string> Ingredients)
        {
            this.Ingredients.AddRange(Ingredients);
        }
        public override string ToString() 
        {
            return $"Назва страви: {Name}, інгредієнти: {string.Join(", ", Ingredients)}";
        }
        public bool Equals(Dish dish)
        {
            return this.Ingredients == dish.Ingredients && this.Name == dish.Name;
        }
    }
}
