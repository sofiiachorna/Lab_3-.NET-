using ProcessingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class OrderOutput : IOrderOutput
    {
        public void showOrder(IMealBuilder builder)
        {
            Console.WriteLine("Your final order:");
            Console.WriteLine(builder.getResult());
        }
    }
}
