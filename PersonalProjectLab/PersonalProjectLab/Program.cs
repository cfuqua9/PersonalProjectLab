using System;

namespace PersonalProjectLab
{
    using System.IO;
    using System;

    class Program
    {
        static void Main()
        {
            String input;
            //prompt the user to enter soup or salad
            Console.Write("Enter your choice (soup or salad):\t");
            input = Console.ReadLine();
            //if the input is soup
            if (input == "soup")
            {
                String item;
                //prompt the user for the type of soup
                Console.Write("what kind soup do you want?\t");
                item = Console.ReadLine();
                //display the ordered items
                Console.WriteLine("You have ordered : " + item + " " + input);
                Console.WriteLine("Thank You For Ordering!");
            }
            //if the user choses salad
            else if (input == "salad")
            {
                int num;
                String toppings;
                //prompt the user for number of toppings
                Console.Write("Enter Number of topping :\t");
                num = Convert.ToInt32(Console.ReadLine());
                //prompt the user to choose from a list of topppings
                Console.Write("croutons\ncarrots\neggs\ntomatoes\ntomatoes\nEnter youe choice:\t");
                toppings = Console.ReadLine();
                //display the ordered items
                Console.WriteLine("You have ordered : " + num + " " + toppings + " " + input);
                Console.WriteLine("Thank You For Ordering!");
            }
        }
    }

}