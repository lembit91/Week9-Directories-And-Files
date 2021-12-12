using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShoppingListFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\lembe\samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a order? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your order:");
                    string userOrder = Console.ReadLine();
                    myShoppingList.Add(userOrder);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach (string order in myShoppingList)
            {
                Console.WriteLine($"Your order: {order}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);


        }
    }
}
