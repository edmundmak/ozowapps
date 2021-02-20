using gameoflife;
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
            sortLetters(startup, inputString);
            playGame(startup);
           
        }
        private static void sortLetters(Startup startup, string inputString)
        {
            var service = startup.Provider.GetRequiredService<IGetSorting>();
            Console.WriteLine(service.sortedListLettersNoBuiltIn(inputString));
        }
        private static void playGame(Startup startup)
        {
            var serviceGame = startup.Provider.GetRequiredService<IGames>();
            serviceGame.PlayGame(1, 10);
            serviceGame.ToggleGridCell(0, 0);
            serviceGame.ToggleGridCell(0, 1);
            serviceGame.ToggleGridCell(0, 2);
            serviceGame.ToggleGridCell(0, 3);
            serviceGame.ToggleGridCell(0, 4);
            serviceGame.ToggleGridCell(0, 5);
            serviceGame.ToggleGridCell(0, 6);
            serviceGame.ToggleGridCell(0, 7);
            serviceGame.ToggleGridCell(0, 8);
            serviceGame.ToggleGridCell(0, 9);
            serviceGame.SetMaxGenerations(50);
            serviceGame.Init();
            Console.ReadKey();
        }

    }
}
