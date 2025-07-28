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
        public Recipient(string Rname,
        int Rhours) 
        {
    name = Rname;
            hours = Rhours;

        }
        public Recipient(string Rname) 
        {
        name=Rname;
            hours=90;
        
        }
        public string GetName() { return name; }
        public int GetHours() { return hours; }

        public void sethours(int H) 
        {
        hours = H;
        }
        public void DisplayRecipient()
        {
            Console.WriteLine("Recipient details:");
            Console.WriteLine("Name: {0} , hours: {1}",name,hours);

        
        }
    }
}
