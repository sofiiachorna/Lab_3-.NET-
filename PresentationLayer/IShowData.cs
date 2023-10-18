using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public interface IShowData
    {
        void showMeals(Dictionary<string, List<Dish>> meals);
        void showMeals<T>(List<T> meals);
        void showAllData();
    }
}
