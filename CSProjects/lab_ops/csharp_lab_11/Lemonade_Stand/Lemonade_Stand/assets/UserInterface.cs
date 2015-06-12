using Lemonade_Stand.assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class UserInterface
    {

        public Player player;
        List<string> ingredient_options = new List<string>{"lemons", "sugar", "ice", "water", "cups"};
        int day_counter;
        public UserInterface()
        {
            if (this.player == null)
            {
                this.player = new Player();
            }
            this.day_counter = 1;
        }
        public void Start()
        {
            this.player.name = this.GetPlayerName();
            while (this.day_counter < 8)
            {
                Day day = new Day();
                if (this.day_counter == 1)
                {
                    this.GiveRundown();
                }
                this.GetGroceryList();

                Console.ReadKey();
                this.day_counter++;

            }
        }

        private void GetGroceryList()
        {
            Console.WriteLine("So what do you think you'll need today?");
            this.ListPrices();
        }

        private void ListPrices()
        {
            Console.WriteLine("{0} dollar[s] a lemon.", lemon_price);
            Console.WriteLine("{0} dollar[s] for 10 cups", cup_price);
            Console.WriteLine("{0} dollar[s] per ounce of sugar", sugar_price);
            Console.WriteLine("{0} dollar[s] for 2 cups of water", water_price);
            Console.WriteLine("{0} dollar[s] will get you a bag of ice, good for ten cups", ice_price);
            throw new NotImplementedException();
        }

        private void GiveRundown()
        {
            Console.WriteLine("Alright {0}, here is the deal.", this.player.name);
            Console.WriteLine("You got what? {0} bucks on you? Well, it'll have to do for now.", this.player.money);
            Console.WriteLine("This, is your Lemonade Stand. It's not much, but it's yours.");
            this.player.lemon_stand.ListIngredients();
            Console.WriteLine("Get all that? Good.");
            Console.WriteLine("First things first, it's a nice day today, so you\nshould be able to make some money...");
            Console.WriteLine("But you don't have any Ice, you'll need to buy some\nif you want to be able to sell any lemonade");
            Console.WriteLine("At the beginning of each day, I'll come check\nif you want me to pick something up from the store");
            Console.ReadKey();
        }

        private string GetPlayerName()
        {
            Console.WriteLine("Welcome to suburbia Kid, what's your name?");
            string user_input = Console.ReadLine();
            return user_input;
        }
        private void optionMenu()
        {
            Console.ReadLine();
            throw new NotImplementedException();
        }
    }
}
