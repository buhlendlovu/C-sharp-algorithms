using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace P5T1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            CarList Lists = new CarList();
           
            int choice = Displayoptions();
            //Lists.ReadData();
            while (choice != 9)

            {
                switch (choice) 
                {
                    case 1:
                        Lists.Addcar();
                        break;
                        case 2:
                        Lists.sellcar();
                        break;
                    case 3:
                        Lists.DeleteCar();
                        break;
                        case 4:
                        Lists.Decrease();
                        break;
                        case 5:
                        Lists.DisplayAbove50K();
                        break;
                        case 6:
                        Lists.Displaybelow50();
                        break;
                    case 7:
                        Lists.DisplayAvailable();
                        break;
                    case 8:
                        Lists.DisplayAll();
                        break;
                        case 9:
                        Console.WriteLine("QUIT THE PROGRAM");
                        break;
                    default:
                        Console.WriteLine("You have entered and icorrect choice,try again");
                        break;
                
                }
                choice = Displayoptions();
            }
            Console.WriteLine("Exiting the program.....");
            Lists.WriteData();
        }
        public static int Displayoptions()
        {
            Console.WriteLine("indicate your choice from the following options,4 to quit");
            Console.WriteLine("1. Add a car to your List.");
            Console.WriteLine("2. Sell a car- set status to sold");
            Console.WriteLine("3. Delete a car- remove a car from the list");
            Console.WriteLine("4. Decrease the price of the car");
            Console.WriteLine("5. Display the registration numbers and prices for cars above R50000");
            Console.WriteLine("6. Display the registration numbers and prices for cars below R50000");
            Console.WriteLine("7. Display the registration numbers and prices for all avaialble cars");
            Console.WriteLine("8. Display all the display fields for all the cars");
            Console.WriteLine("9. Quit");
            Console.Write("CHOICE:");
            int CHOICE = int.Parse(Console.ReadLine());
            return CHOICE;
        }
    }
}
