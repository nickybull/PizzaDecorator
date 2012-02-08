using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            int response1;
            string response2;
            int response3;
            bool IsToppingSelected = false;
            bool IsMakeSelected = false;
            Pizza choice;
            Pizza describe;
            Console.WriteLine("\n Welcome to Pizza Shack! What Kind of Pizza would you like?");
            Console.WriteLine("\n 1 for Thin Crust");
            Console.WriteLine("\n 2 for Thick Crust");
            Console.WriteLine("\n 3 for Chicago Style");
            Console.WriteLine("\n 4 for New York Style");
            response1 = Convert.ToInt32(Console.ReadLine());

            switch (response1)
            {
                case 1:
                    choice = new ThinCrust();
                    break;
                case 2:
                    choice = new ThickCrust();
                    break;
                case 3:
                    choice = new Chicago();
                    break;
                case 4:
                    choice = new NewYork();
                    break;
                default:
                    Console.WriteLine("\n Invalid number, defaulting to Thin Crust...");
                    choice = new ThinCrust();
                    break;
            }

            describe = choice;

            while (!IsToppingSelected)
            {
                Console.WriteLine("\n You have selected: " + choice.getDescription() + ". What would you like on your pizza? To get pizza description type 'describe' and the number you want to hear about.");
                Console.WriteLine("\n 1 for Hawaiian");
                Console.WriteLine("\n 2 for MeatLovers");
                Console.WriteLine("\n 3 for Veggie");
                Console.WriteLine("\n 4 for Supreme");
                Console.WriteLine("\n 5 for Everything");
                Console.WriteLine("\n 6 for Make Your Own");
                response2 = Console.ReadLine();
                describe = choice;

                switch (response2)
                {
                    case "describe 1":
                        describe = new Hawaiian(describe);
                        Console.WriteLine("\n " + describe.getDescription());
                        Console.WriteLine("\n " + describe.cost());
                        break;
                    case "describe 2":
                        describe = new MeatLovers(describe);
                        Console.WriteLine("\n " + describe.getDescription());
                        Console.WriteLine("\n " + describe.cost());
                        break;
                    case "describe 3":
                        describe = new Veggie(describe);
                        Console.WriteLine("\n " + describe.getDescription());
                        Console.WriteLine("\n " + describe.cost());
                        break;
                    case "describe 4":
                        describe = new Supreme(describe);
                        Console.WriteLine("\n " + describe.getDescription());
                        Console.WriteLine("\n " + describe.cost());
                        break;
                    case "describe 5":
                        describe = new Everything(describe);
                        Console.WriteLine("\n " + describe.getDescription());
                        Console.WriteLine("\n " + describe.cost());
                        break;
                    case "1":
                        choice = new Hawaiian(choice);
                        IsToppingSelected = true;
                        break;
                    case "2":
                        choice = new MeatLovers(choice);
                        IsToppingSelected = true;
                        break;
                    case "3":
                        choice = new Veggie(choice);
                        IsToppingSelected = true;
                        break;
                    case "4":
                        choice = new Supreme(choice);
                        IsToppingSelected = true;
                        break;
                    case "5":
                        choice = new Everything(choice);
                        IsToppingSelected = true;
                        break;
                    case "6":
                        IsToppingSelected = true;
                        IsMakeSelected = true;
                        break;
                    default:
                        Console.WriteLine("\n Invalid response, defaulting to Make Your Own Pizza");
                        IsToppingSelected = true;
                        IsMakeSelected = true;
                        break;
                }
            }

            while (IsMakeSelected)
            {
                Console.WriteLine("\n What would you like on your Pizza? Type 0 when you have finished making your Pizza.");
                Console.WriteLine("\n 1 for Cheese");
                Console.WriteLine("\n 2 for Pepperoni");
                Console.WriteLine("\n 3 for Onions");
                Console.WriteLine("\n 4 for Peppers");
                Console.WriteLine("\n 5 for Sausage");
                Console.WriteLine("\n 6 for Bacon");
                Console.WriteLine("\n 7 for Pineapple");
                Console.WriteLine("\n 8 for Ham");
                Console.WriteLine("\n 9 for Mushrooms");
                response3 = Convert.ToInt32(Console.ReadLine());

                switch (response3)
                {
                    case 0:
                        IsMakeSelected = false;
                        break;
                    case 1:
                        choice = new Cheese(choice);
                        break;
                    case 2:
                        choice = new Pepperoni(choice);
                        break;
                    case 3:
                        choice = new Onions(choice);
                        break;
                    case 4:
                        choice = new Peppers(choice);
                        break;
                    case 5:
                        choice = new Sausage(choice);
                        break;
                    case 6:
                        choice = new Bacon(choice);
                        break;
                    case 7:
                        choice = new Pineapple(choice);
                        break;
                    case 8:
                        choice = new Ham(choice);
                        break;
                    case 9:
                        choice = new Mushrooms(choice);
                        break;
                    default:
                        Console.WriteLine("\n Invalid response, Please type one of the valid toppings.");
                        break;
                }

            }

            Console.WriteLine("\n You have selected: " + choice.getDescription() + "\n That will be: $" + choice.cost());
            Console.ReadKey();
        }
    }
}
