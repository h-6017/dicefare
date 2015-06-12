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
        int day_counter;
        public UserInterface()
        {
            if (this.player == null)
            {
                this.player = new Player();
            }
            if (this.day_counter == null)
            {
                this.day_counter = 1;
            }
        }
        public void Start()
        {
            while (this.day_counter < 8)
            {
                Day day = new Day();
                Customer new_customer = new Customer(day);
                Console.WriteLine("I don't do anything yet");
                Console.WriteLine(this.player.name);
                Console.WriteLine(new_customer.money_to_spend);
                Console.ReadKey();
            }
        }
    }
}
