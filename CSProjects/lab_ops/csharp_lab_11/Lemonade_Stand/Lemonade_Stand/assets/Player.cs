using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand.assets
{
    class Player
    {
        public Stand lemon_stand;
        public int money;
        public string name;
        public Player()
        {
            this.name = "John Doe";
            this.money = 25;
            if (this.lemon_stand == null)
            {
                this.lemon_stand = new Stand();
            }
        }

        public Player(string name)
        {
            this.name = name;
            this.money = 25;
        }

        public void purchasIngredients()
        {
            throw new NotImplementedException();
        }

        public void setPrice(int price_per_cup)
        {
            this.lemon_stand.price_per_cup = price_per_cup;
        }
        public void StartSales()
        {
            throw new NotImplementedException();
        }

    }

}
