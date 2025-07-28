using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesPerson personOne = new SalesPerson("John", 0.08, 8000);
            SalesPerson personTwo = new SalesPerson("Susan", 0.08, 0);
            if (personTwo.GetSales() > personOne.GetSales())
            {
                Console.WriteLine("{0} has high sales than the one", personOne.GetName());
            }
            else if (personTwo.GetSales() < personOne.GetSales()) 
            {
                Console.WriteLine("{0} has low sales than the one", personTwo.GetName());
            }
            else
            {
                { Console.WriteLine("HAS THE SAME SALES"); }
            }
            personOne.DisplayPerson();
               personTwo. DisplayPerson();
        }
    }
}
