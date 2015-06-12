using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dCC_lab_10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program self = new Program();
            
            self.printOutput(getUserInput());

            Console.ReadKey();
        }
        private void printOutput(List<object> obj_list)
        {
            string word = Convert.ToString(obj_list[0]);
            int number = Convert.ToUInt16(obj_list[1]);
            List<char> word_split = new List<char>();
            foreach (char elem in word)
            {
                word_split.Add(elem);
            }
            Console.WriteLine(word_split[number]);
        }
        static List<object> getUserInput()
        {
            List <object> obj_list = new List<object>();
            Console.WriteLine("Please enter any word you like");
            string user_word_choice = Console.ReadLine();
            Console.WriteLine("Now, if you wouldn't mind... could I trouble you for a number as well?");
            string user_number_choice = Console.ReadLine();
            int user_number = Convert.ToInt16(user_number_choice);
            obj_list.Add(user_word_choice);
            obj_list.Add(user_number_choice);
            return obj_list;

        }
    }
}
