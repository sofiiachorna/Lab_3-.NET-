using Microsoft.Extensions.DependencyInjection;
using DataLayer;
using ProcessingLayer;
using PresentationLayer;
using ProcessingLayer.builders;
using System.Text;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = Encoding.UTF8;

            var services = new ServiceCollection();
            services.AddSingleton<IData, Data>();
            services.AddSingleton<IDataManager,DataManager>();
            services.AddSingleton<IDirector,Director>();
            services.AddTransient<IShowData,ShowData>();
            services.AddTransient<IUserInput,UserInput>();
            services.AddTransient<IOrderOutput,OrderOutput>();

            services.BuildServiceProvider().GetService<IUserInput>().makeOrder();
        }
        
    }
}
