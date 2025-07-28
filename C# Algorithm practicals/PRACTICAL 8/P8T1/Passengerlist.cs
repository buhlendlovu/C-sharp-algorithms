using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace P7T1
{
    internal class Passengerlist
    {
        ArrayList list;
       

        public Passengerlist()
        {
            list = new ArrayList();
            ReadData();
        }
        public int Count()
        {
            return list.Count;
        }
        public void BuildIndex(IndexList indexlist)
        { 
            for (int i = 0; i < list.Count; i++)
            {
                Passenger cur = (Passenger)list[i];
                int passnum = cur.Getnum();

                Index curIN = new Index(passnum, i);
                
                indexlist.AddIndex(curIN);

            }
            indexlist.BubbleSort();
        }
        public void Addnew(Passenger newP, IndexList InList)
        {
            list.Add(newP);
            int passnum = newP.Getnum();
            Index PassIn = new Index(passnum, list.Count - 1);
            InList.AddIndex(PassIn);
        }
        public void Delete(int pos)
        {

            list.RemoveAt(pos);
        }
        public Passenger Getpassenger(int wanted)
        {

           return (Passenger)list[wanted];

        }

    
    public void DisplayDetails()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Passenger current = (Passenger)list[i];
            current.DisplayAll(i + 1);
        }
    }
    public void DisplayOne(int pos)
    {
        pos--;
        Passenger current = (Passenger)list[pos];
        current.Display1();
    }
    public void DisplayRoute(string wanted)
    {
        string finds;
        for (int i = 0; i < list.Count; i++)
        {
            Passenger current = (Passenger)list[i];
            finds = current.GetRoute();
            if (wanted == finds)
            {
                current.Display1();
            }
        }
    }
    public void Update(int pos, string status)
    {
        Passenger current = (Passenger)list[pos];

        current.Setstatus(status);
    }

    public void ReadData()
    {
        const string text = "PassengerData.txt";
        int passnum;
        string surname;
        string initials;
        string route;
        string date;
        double amount;
        string status;
        string inputline;
        string[] field;
        const char comma = ',';

        StreamReader sr = new StreamReader(text);
        inputline = sr.ReadLine();
        while (inputline != null)
        {
            field = inputline.Split(comma);

            passnum = int.Parse(field[0]);
            surname = field[1];
            initials = field[2];
            route = field[3];
            date = field[4];
            amount = double.Parse(field[5]); ;
            status = field[6];

            Passenger newP = new Passenger(passnum, surname, initials, route, date, amount, status);
            list.Add(newP);
            
            inputline = sr.ReadLine();
        }
        sr.Close();
    }
    public void WriteData()
    {
        const string text = "WriteData.txt";

        StreamWriter sw = new StreamWriter(text);

        for (int i = 0; i < list.Count; i++)
        {
            Passenger current = (Passenger)list[i];
            int passnum = current.Getnum();
            string surname = current.Getsurname();
            string initials = current.GetInitials();
            string route = current.GetRoute();
            string date = current.GetDate();
            double amount = current.GetAmount();
            string status = current.GetStatus();
            const char comma = ',';

            sw.WriteLine(passnum + "," + surname + comma + initials + comma + route + comma + date + comma + amount + comma + status);

        }
        sw.Close();
    }
}
}
    

