using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLayer
{
    public interface IDirector
    {
        void setBuilder(IMealBuilder builder);
        void createOrder(string type);
        void createOrder(string type, List<string> dishes);
        void createOrder(string type, List<string> dishes, List<List<string>> Ingredients);
        
    }
}
