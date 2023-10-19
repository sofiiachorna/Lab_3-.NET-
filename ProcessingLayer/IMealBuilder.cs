using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessingLayer.products;

namespace ProcessingLayer
{
    public interface IMealBuilder
    {
        void reset();
        void setData(IData data);
        void addMealType(string type);
        void addDish(string type,string dishName);
        void addIngredient(string dish, List<string> ingredient);
        Order getResult();

    }
}
