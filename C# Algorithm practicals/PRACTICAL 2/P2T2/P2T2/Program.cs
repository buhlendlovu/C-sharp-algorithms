using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P2T2
{
    internal class Program
    {
        const int SIZE= 4;
        static void Main(string[] args)
        {
            Recipient[] recList = new Recipient[SIZE];
            int count = 0;
            for (int i = 0; i <= SIZE; i++)//call add method
            {
                AddRecipient( recList, ref  count);


            }
            Console.WriteLine();
            for (int i = 0; i <= SIZE; i++)// call the display method
            {
                recList[i].DisplayRecipient();
            }
            Console.ReadLine();
        }
        public static void AddRecipient(Recipient[] recList, ref int count)
        {


            Console.Write("Enter the name of the recipient: ");
            string name = Console.ReadLine();
            Console.Write("Should this recipient be allocated 90 hours (Y/N): ");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'Y' || choice == 'y')
            {
                recList[count] = new Recipient(name);//call constructor with provided values
                count++;

            }
            else
            {
                Console.Write("Enter the number of hours required: ");
                int hours = int.Parse(Console.ReadLine());
                recList[count] = new Recipient(name, hours);
                count++;

            }
            
        }
    }

}
