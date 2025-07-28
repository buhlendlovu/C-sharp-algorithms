using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2T2
{
    internal class Recipient
    {
        string name;
        int hours;
        public Recipient(string rname, int rhours)
        {
            name = rname;
          hours = rhours;
            

        }
        public Recipient(string rname )
        { 
            name = rname;
            hours = 90;
        }
        public string Getname()
        { 
            return name;
        }
        public void SetHours(int H)
        { 
            hours = H;
        }
        public void DisplayRecepient() 
        {
            Console.WriteLine("recipient details");
            Console.WriteLine("Name: {0} , Hours {1}",name,hours); 
        }
    }
}
