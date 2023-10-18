using Microsoft.Extensions.DependencyInjection;
using DataLayer;
using ProcessingLayer;
using PresentationLayer;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args) 
        {
            var services = new ServiceCollection();
            services.AddSingleton<IData, Data>();
            services.AddSingleton<IDataManager,DataManager>();
            services.AddTransient<IShowData,ShowData>();
            services.AddSingleton<IDirector,Director>();
            services.AddTransient<IUserInput,UserInput>();
            services.AddTransient<IOrderOutput,OrderOutput>();

            services.BuildServiceProvider().GetService<IUserInput>().makeOrder();
        }
        
    }
}
