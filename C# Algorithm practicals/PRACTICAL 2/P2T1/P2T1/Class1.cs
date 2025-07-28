using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2T1
{
    internal class SalesPerson
    {
       string name;
        double comRate = 0.08;
        double salAmount;

        public SalesPerson(string rname, double rrate, double rsalAmount)
        {
            name= rname;
            comRate= rrate;
            salAmount= rsalAmount;

        }

        public string GetName()
        {
            return name;
        }
        public double GetSales()
        {
            return salAmount;
        }
        public void SetSales(double salAmount)
        {
          this.salAmount = salAmount;
        }
        public void DisplayPerson()
        {
            Console.WriteLine("Attributes : name {0} , rate {1} and sales amount {2}", name,comRate,salAmount);
         //   Console.WriteLine("Attributes : name {0} , rate{1} and sales amount{2}", name, comRate, salAmount);
        }
    }
}
