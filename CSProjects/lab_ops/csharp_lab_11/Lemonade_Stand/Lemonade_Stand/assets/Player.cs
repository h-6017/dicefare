using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand.assets
{
    class Player
    {
        public bool purchasing;
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

        public void purchaseIngredients()
        {
            purchasing = true;
            while (purchasing)
            {
                if (this.money > 0)
                {
                    Console.WriteLine("Which ingredient you want?");
                    UserInterface.listIngredients();
                    Console.WriteLine();
                    Console.WriteLine("Just say 'done' to finish up");
                    string user_input = Console.ReadLine();
                    switch (user_input.ToLower())
                    {
                        case "lemons":
                            this.purchase_lemons();
                            break;
                        case "ice":
                            this.purchase_ice();
                            break;
                        case "water":
                            this.purchase_water();
                            break;
                        case "cups":
                            this.purchase_cups();
                            break;
                        case "sugar":
                            this.purchase_sugar();
                            break;
                        case "hose":
                            this.add_water();
                            break;
                        case "done":
                            Console.WriteLine("Alright, kid. Good luck!");
                            purchasing = false;
                            break;
                        default:
                            Console.WriteLine("I'm not sure what you mean");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry bud, you are broke... You'll have to make do");
                    purchasing = false;
                }

            }

        }

        private int getAmount()
        {
            Console.WriteLine("How much you thinking?");
            string user_input = Console.ReadLine();
            return (Int16.Parse(user_input));
        }

        private void add_water()
        {
            this.lemon_stand.cups_of_water += 100;
        }

        private void purchase_sugar()
        {
            int amount = this.getAmount();
            this.lemon_stand.ounces_of_sugar += amount;
            Console.WriteLine("Looks Like you have {0} ounces of sugar now.", this.lemon_stand.ounces_of_sugar);
            this.money = (this.money - (amount * UserInterface.sugar_price));
        }

        private void purchase_cups()
        {
            int amount = this.getAmount();
            this.lemon_stand.cups += amount;
            Console.WriteLine("Looks Like you have {0} cups now.", this.lemon_stand.cups);
            this.money = (this.money - (amount * UserInterface.cup_price));
        }

        private void purchase_water()
        {
            int amount = this.getAmount();
            this.lemon_stand.cups_of_water += amount;
            Console.WriteLine("Looks Like you have {0} cups of water now.", this.lemon_stand.cups_of_water);
            this.money = (this.money - (amount * UserInterface.water_price));
        }

        private void purchase_ice()
        {
            int amount = this.getAmount();
            this.lemon_stand.cups_of_ice += amount;
            Console.WriteLine("Looks Like you have {0} cups of ice now.", this.lemon_stand.cups_of_ice);
            this.money = (this.money - (amount * UserInterface.ice_price));
        }

        private void purchase_lemons()
        {
            int amount = this.getAmount();
            this.lemon_stand.lemons += amount;
            Console.WriteLine("Looks Like you have {0} lemons now.", this.lemon_stand.lemons);
            this.money = (this.money - (amount * UserInterface.lemon_price));
        }

        public void setPrice(int price_per_cup)
        {
            this.lemon_stand.price_per_cup = price_per_cup;
        }

//       public void StartSales(int price)
//       {
//           foreach (Customer customers in UserInterface.day )
//           {
//               if()
//               {

//               } 
//           }
//            throw new NotImplementedException();
//        }
    }

}
