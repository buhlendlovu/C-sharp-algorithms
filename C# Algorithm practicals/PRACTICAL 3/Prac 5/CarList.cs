using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Prac_5
{
    internal class CarList
    {
       const int SIZE = 10;
       Car[] List;//declaring a list as an array that will provide methods to cater for any list funvtionality required
       int nrEl = 0;
        public CarList()
        {
            List = new Car[SIZE];//array of cars
            ReadData();

        }

        public int Count()
        { 
            return nrEl; //returns nr of cars in the list
        }
        public void Add()
        {
            if (nrEl > SIZE)
            {
                WriteLine("The list is full");
            }
            else 
            {
                Write("Enter the car registration number: ");
                string regNum=ReadLine();
                Write("Enter the car model name: ");
                string modelName=ReadLine();
                Write("Enter the year: ");
                int year=int.Parse(ReadLine());
                Write("Enter the colour: ");
                string colour=ReadLine();
                Write("Enter the price: ");
                double price=double.Parse(ReadLine());
                List[nrEl].SetStatus(true);
                List[nrEl]=new Car(regNum, modelName, year, colour, price); 
                nrEl++;

            }
        }
        public void DisplayAvaible() 
        {
            if (nrEl == 0) 
            {
                WriteLine("The list is empty");
            }
            else
            {
                for (int i = 0; i < nrEl; i++)
                {
                    List[i].GetStatus();
                    List[i].DisplayCar();
                }
            }
        }
        public void DisplayAll() 
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
                }
            }
        }

    }

}
