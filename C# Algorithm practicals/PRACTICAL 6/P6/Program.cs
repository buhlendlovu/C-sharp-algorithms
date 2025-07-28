using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace P6
{
    internal class Program
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            CarList carList = new CarList();
            int option = 0;
            option=GetOption(option);
            while (option != 9)
            { 

            }
        }
        public static int GetOption(int option)
        {
            WriteLine("Indicate your choice from the following option and press 9 to quit");
            WriteLine("1. Add a car to the list");
            WriteLine("2. Sell a car _ set status to sold");
            WriteLine("3. Delete a car _remove  car from the list");
            WriteLine("4. Decrease the price of the car");
            WriteLine("5. Display the registration numbers and prices of cars above R50 000");
            WriteLine("6. Display the registration numbers and prices of cars below R50 000");
            WriteLine("7. Display registration numbers and prices for all available cars");
            WriteLine("8. Display all the fields for all the cars ");
            WriteLine("9. Quit");
            Write("Enter your choice: ");
            option = int.Parse(ReadLine());
            return option;
        }

    }
}
