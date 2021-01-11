using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sorting;
using System;
using System.Text.RegularExpressions;

namespace ozowapps
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            string inputString = Console.ReadLine();
            // instantiate startup
            // all the constructor logic would happen
            var startup = new Startup();
            // request an instance of type ISomeService
            // from the ServicePipeline built
            // returns an object of type SomeService
            var service = startup.Provider.GetRequiredService<IGetSorting>();
            Console.WriteLine(service.sortedListLettersNoBuiltIn(inputString));
        }
       
    }
}
