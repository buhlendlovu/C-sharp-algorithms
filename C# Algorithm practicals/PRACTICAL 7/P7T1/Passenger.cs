using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;


namespace P7T1
{
    internal class Passenger
    {
        int passNum;
        string surname;
        string initials;
        string route;
        string date;
        double ticket;
        string status;
        public Passenger(int passNum,string surname,string initials,string route,string date,double ticket,string status) 
        { 
            this.passNum = passNum;
            this.surname = surname;
            this.initials = initials;
            this.route = route;
            this.date = date;
            this.ticket = ticket;
            this.status = status;
        }
        public int GetPassNum()
        {
            return passNum;
        }
        public string GetSurname()
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
        public double GetTicket()
        {
            return ticket;
        }
        public string GetStatus()
        {
            return status; 
        }
        
        public void DisplayPass()
        {
            WriteLine("Passenger Number: {0}, Surname: {1}, Initials: {2}, Route: {3}, Date: {4}, Ticket Amount: {5}, Status: {6}",passNum,surname,initials,route,date,ticket,status);
        }
    }
}
