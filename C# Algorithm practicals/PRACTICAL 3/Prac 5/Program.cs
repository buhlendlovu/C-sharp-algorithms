             using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.ComponentModel;

namespace Prac_5
{
    internal class Program
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            CarList carList = new CarList();
            int option = 0;
            option=GetOption(option);
            while (option != 4)
            {
                switch (option) 
                {
                    case 1:
                        carList.Add();
                        break;
                    case 2:
                        carList.DisplayAvaible();
                        break;
                    case 3:
                        carList.DisplayAll();
                        break;
                    case 4:
                        WriteLine(".....");
                        break;
                    default:
                        WriteLine("Invalid option");
                        break;
                }
            }
            option = GetOption(option);
            WriteLine();
        }
        static int GetOption(int option)
        {
            WriteLine("Indicate your choice from the following options, 4 to quit");
            WriteLine("1. Add a car to the list");
            WriteLine("2. Display the registration numbers and prices for all available cars");
            WriteLine("3. Display all the fields for all cars");
            WriteLine("4. Quit");
            Write("Enter your choice: ");
            option=int.Parse(Console.ReadLine());
            return option;
        }
    }
}
