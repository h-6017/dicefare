using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand.assets
{
    class Stand
    {
        public int lemons;
        public int ounces_of_sugar;
        public int cups_of_water;
        public int cups_of_ice;
        public int cups;
        public int price_per_cup;
        public Stand()
        {
            price_per_cup = 1;
            lemons = 5;
            ounces_of_sugar = 5;
            cups_of_water = 10;
            cups_of_ice = 0;
            cups = 50;
        }
        public void ListIngredients()
        {
            Console.WriteLine("Here's what you got:");
            Console.WriteLine("Cups   :{0}", cups);
            Console.WriteLine("Lemons :{0}", lemons);
            Console.WriteLine("Sugar  :{0}[ounces]", ounces_of_sugar);
            Console.WriteLine("Water  :{0}[cups]", cups_of_water);
            Console.WriteLine("Ice    :{0}[cups]", cups_of_ice);
        }
        public void ListPrice()
        {
            Console.WriteLine("Right now your sign says a glass\n of lemonade costs {0} bucks", price_per_cup);
        }
    }
}
