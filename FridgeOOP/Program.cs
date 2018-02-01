using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrideOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            Fridge userFridge = new Fridge(false, "deluxe dispenser", 70, true);




            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, Type 1.");
                Console.WriteLine("To change the light bulb, Type 2.");
                Console.WriteLine("To clean, Type 3.");
                Console.WriteLine("To take food, Type 4.");
                Console.WriteLine("To check food supplies, Type 5.");
                Console.WriteLine("To see all fridge details, Type 6.");
                //Console.WriteLine("To restart,  Type 7.");
                Console.WriteLine("To quit, Type 8.");

                userChoice = int.Parse(Console.ReadLine());

                

                switch (userChoice)
                {

                    case 1:
                        userFridge.DispenseWater();
                        break;
                    case 2:
                       Console.WriteLine(userFridge.ChangeTheBulbs());
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;
                    case 4:
                        Console.WriteLine("How much food do you want to remove?");
                        Console.WriteLine("Please type a whole number.");
                        int foodNumber = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodNumber);
                        Console.WriteLine(userFridge.FoodAmount + " food left in the fridge.");
                       break;

                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;

                    case 6:
                        
                        Console.WriteLine("Details in the fridge:");
                        Console.WriteLine("It is {0} that the fridge is clean \nThis fridge has a {1} \nThere is {2} amount of food left \nDo the bulbs work: {3}", userFridge.IsClean, userFridge.DispenserType, userFridge.FoodAmount, userFridge.BulbsWork);

                        break;

                    default:
                        break;

                }


            }  while (userChoice != 8) ;
        }
    }
}
