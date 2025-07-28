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
           
            int option = Displayoptions();
            //Lists.ReadData();
            while (option != 4)

            {
                switch (option) 
                {
                    case 1:
                        Lists.Addcar();
                        break;                   
                    case 2:
                        Lists.DisplayAvailable();
                        break;
                    case 3:
                        Lists.DisplayAll();
                        break;                       
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 - 9");
                        break;
                
                }
                option = Displayoptions();
            }
            Console.WriteLine("Thank you for using application. Quitting...");
            Lists.WriteData();
        }
        public static int Displayoptions()
        {
            Console.WriteLine("indicate your choice from the following options,4 to quit");
            Console.WriteLine("1. Add a car to your List.");           
            Console.WriteLine("2. Display the registration numbers and prices for all avaialble cars");
            Console.WriteLine("3. Display all the display fields for all the cars");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
