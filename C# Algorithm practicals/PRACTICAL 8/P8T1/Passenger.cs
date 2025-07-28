using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7T1
{
    internal class Passenger
    {
        int passnum;
        string surname;
        string initials;
        string route;
        string date;
        double amount;
        string status;

        public Passenger(int passnum, string surname, string initials, string route, string date, double amount, string status)
        {
            this.passnum = passnum;
            this.surname = surname;
            this.initials = initials;
            this.route = route;
            this.date = date;
            this.amount = amount;
            this.status = status;
        }
        public Passenger()
        {

        }
        public int Getnum()
        {
            return passnum;
        }
        public string Getsurname()
        {
            return surname;
        }
        public string GetInitials()
        {
            return initials;
        }
        public string GetRoute()
        {
            return route;
        }
        public string GetDate()
        {
            return date;
        }
        public double GetAmount()
        {
            return amount;
        }
        public string GetStatus()
        {
            return status;
        }
        public void Setnum(int passnum)
        {
            this.passnum = passnum;
        }
        public void Setsurname(string surname)
        {
            this.surname = surname;
        }
        public void Setinitials(string initials)
        {
            this.initials=initials;
        }
        public void Setroute(string route)
        {
            this.route = route;
        }
        public void Setdate(string date)
        {
            this.date=date;
        }
        public void Setamount(double amount)
        {
            this.amount = amount;
        }
        public void Setstatus(string status)
        {
            this.status = status;
        }
        public void DisplayAll(int num)
        {
         Console.WriteLine("passenger {0} details :{1},{2},{3},{4},{5},{6:C},{7}",num, passnum, surname, initials, route, date, amount, status);
        }
        public void Display1()
        {
            Console.WriteLine("passenger details :{0},{1},{2},{3},{4},{5:C},{6}", passnum, surname, initials, route, date, amount, status);
        }
        
    }
}
