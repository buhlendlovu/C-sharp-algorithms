using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using static System.Console;


namespace P7T1
{
    class PassengerList
    {
        ArrayList List;

        public PassengerList()
        {
            List = new ArrayList();
            ReadData();
        }

        public void AddPassenger(Passenger newOne)
        {
            List.Add(newOne);
        }

        public void DeletePassenger(int pos)
        {
            List.RemoveAt(pos - 1);
        }

        public int FindPass(int wanted)
        {
            int pos = -1;
            for (int x = 0; x < List.Count; x++)
            {
                Passenger currentPass = (Passenger)List[x];
                if (currentPass.GetPassNum() == wanted)
                    pos = x;
            }

            return pos + 1;
        }

        public Passenger GetPass(int pos)
        {
            pos--;
            if ((pos >= 0) && (pos < List.Count))
                return (Passenger)List[pos];
            else
                return null;
        }
        
        public void DisplayAll()
        {
            for (int x = 0; x < List.Count; x++)
            {
                Passenger currentPass = (Passenger)List[x];
                currentPass.DisplayPass();
            }
        }
        public void DisplayRoute()
        {
            Write("Enter the route you want to view: ");
            string wanted = ReadLine().ToUpper();
            
            
            for (int x = 0; x < List.Count; x++)
            {
                Passenger current = (Passenger)List[x];
                if (current.GetRoute() == wanted)
                {
                    current.DisplayPass();
                }               
            }
            
        }
        public void DisplayOne()
        {
            Write("Enter the passenger number of the passenger you want to view: ");
            int wanted = int.Parse(ReadLine());
            int pos = FindPass(wanted);

            for (int x = 0; x < List.Count; x++)
            {
                Passenger current = (Passenger)List[x];
                if (current.GetPassNum() == wanted)
                {
                    Write("{0}.",pos);
                    current.DisplayPass();
                }
                else
                WriteLine("The passenger was not found.");
            }
        }
        public void Close()
        {
            WriteData();
        }
        
        private void ReadData()
        {
            const char DELIM = ',';
            string[] fields;
            string inputline;
            int passNum;
            string surname;
            string initials;
            string route;
            string date;
            double ticket;
            string status;
            StreamReader sr = new StreamReader("PassengerData.txt");
            inputline = sr.ReadLine();
            while (inputline != null)
            {
                fields = inputline.Split(DELIM);
                passNum = int.Parse(fields[0]);
                surname = fields[1];
                initials = fields[2];
                route = fields[3];
                date = fields[4];
                ticket = double.Parse(fields[5]);
                status = fields[6];

                Passenger newOne=new Passenger(passNum, surname, initials, route, date, ticket, status);
                List.Add(newOne);
                inputline = sr.ReadLine();
            }
            sr.Close();
        }
        private void WriteData()
        {
            StreamWriter wr = new StreamWriter("OutputPassData.txt");
            for (int x = 0;x < List.Count; x++)
            {
                Passenger currentPass = (Passenger)List[x];
                wr.Write(currentPass.GetPassNum() + ",");
                wr.Write(currentPass.GetSurname() + ",");
                wr.Write(currentPass.GetInitials() + ",");
                wr.Write(currentPass.GetRoute() + ",");
                wr.Write(currentPass.GetDate() + ",");
                wr.Write(currentPass.GetDate() + ",");
                wr.WriteLine(currentPass.GetStatus());
            }
            wr.Close();
        }
    }
}
