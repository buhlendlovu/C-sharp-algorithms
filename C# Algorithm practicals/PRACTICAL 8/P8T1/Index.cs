using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7T1
{
    internal class Index
    {

        int passnum;
        int passpos;

        public Index(int passnum, int passpos)
        {
            this.passnum = passnum;
            this.passpos = passpos;
        }
        public int Getpassnum()
        {
            return passnum;
        }
        public int Getpasspos()
        {
            return passpos;

        }
        public void Display(int pos)
        {
            Console.WriteLine("Index Position {0} \t Passenger number {1} \t Passenegr position {2}",pos,passnum,passpos+1);
        }
    }
}
