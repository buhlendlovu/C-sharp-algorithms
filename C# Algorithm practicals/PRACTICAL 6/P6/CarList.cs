using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace P6
{
    internal class CarList
    {
        const int SIZE = 10;
        Car[] List;//declaring a list as an array  that will provide methods  to cater for any list functionality required
        int nrEl = 0;
        public CarList( )//CONSTRUCTOR
        { 
            List = new Car[SIZE];
            ReadData();
        }
        public int Count()
        { 
            return nrEl; 
        }
        public void AddCar()
        {
            int nrEl = List.Count();
            if (nrEl>SIZE)
            {
                WriteLine("list is full");
            }
            else
            {
                Write("Enter the registration number of the car: ");
                string regNum = ReadLine();
                regNum=regNum.ToUpper();
                Write("Enter the model of the car: ");
                string modelname= ReadLine();
                Write("Enter year: ");
                int year = int.Parse(ReadLine());
                Write("Enter the price of the car: ");
                double price=double.Parse(ReadLine());
                Write("Enter the status (sold/available): ");
                bool status=bool.Parse(ReadLine());
                List[nrEl]= new Car(regNum,modelname, year, price,status);
                nrEl++;
                WriteLine();
            }
        }
        public void ReadData()    
        {
            const char DELIM= ',';
            string inputline;
            string[] fields;
            string regNum;
            string modelname;
            int year;
            string colour;
            double price;
            bool status;
            StreamReader reader = new StreamReader("CarDetails.txt");
            inputline=reader.ReadLine();
            while (inputline != null)
            { 
                fields=inputline.Split(DELIM);
                regNum= fields[0];
                modelname= fields[1];
                year=int.Parse(fields[2]);
                colour= fields[3];
                price=double.Parse(fields[4]);
                status=bool.Parse(fields[5]);
                inputline = reader.ReadLine();
            }
            reader.Close();

        }
        public void DiplayAvailable()
        {
            if (nrEl == 0)
            {
                WriteLine("The list is empty");
            }
            else
            {
                for (int i = 0; i < nrEl; i++)
                {
                    if (List[i].GetStatus() == true)
                    {
                        List[i].DisplayCar();

                    }
                }
                WriteLine();
            }
        }
        public void DisplayDetails() 
        {
            if (nrEl == 0)
            {
                WriteLine("The list is empty");
            }
            else
            {
                for (int i = 0; i < nrEl; i++)
                {
                    List[i].DisplayDetailCar();
                    WriteLine();
                }
            }
        }
        public static void WriteData(Car[]List,int nrEl) 
        {
            StreamWriter wr = new StreamWriter("Cartxt");
            for (int i = 0; i < nrEl; i++) 
            {
                wr.WriteLine(List[i].GetRegNum());
                wr.WriteLine(List[i].GetModelname());
                wr.WriteLine(List[i].GetYear());
                wr.WriteLine(List[i].GetColour());
                wr.WriteLine(List[i].GetPrice());
                wr.WriteLine(List[i].GetStatus());  

            }
            wr.Close();
        }
        public void SellCar() 
        { 
            Write("Enter the registration ")

        }
       public void DeleteCar(int pos) 
       {
            pos--;//decrease position to cater for the array
            for (int i = pos; i < nrEl; i++)
            {
                List[i] = List[i + 1];
                nrEl--;
            }

       }

    }
}
