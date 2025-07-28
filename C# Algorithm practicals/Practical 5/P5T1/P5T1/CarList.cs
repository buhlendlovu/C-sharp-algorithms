using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P5T1
{
    internal class CarList
    {
        const int SIZE = 10;
       
        Car[] List;
        int nrel;
        public CarList()
        {
        
        List = new Car[SIZE];
            nrel = 0;
            ReadData();
        }
        
        public void ReadData() 
        {
            const char DELIM = ',';
            string[] fields;
            string inputline;
            string RegNo;
            double Price;
            string ModelName;
            int year;
            string status;
            string color;
            StreamReader sr = new StreamReader("carData.txt");
            inputline = sr.ReadLine();
            while (inputline != null) 
            {
                fields = inputline.Split(DELIM);
                RegNo = fields[0].ToUpper();             
                ModelName = fields[1];
                year = int.Parse(fields[2]);
                color = fields[3];
                Price = double.Parse(fields[4]);
                status = fields[5];
               
                List[nrel]= new Car( RegNo,  ModelName,  year,  color,  Price,status);  
               nrel++;
                inputline = sr.ReadLine();
            }
            sr.Close();
        }
        public int count()
        {          
            return nrel;                
        }
        public void Addcar() 
        {
         

              if (nrel > SIZE)
              {
                  Console.WriteLine("The array is full");
              }
              else 
              {
                  Console.Write("Enter the cars registration:");
                  string regno= Console.ReadLine();
                  regno= regno.ToUpper();
                  Console.Write("Enter the brand of the car:");
                  string name= Console.ReadLine();
                  Console.Write("Enter the year of the car:");
                  int year= int.Parse(Console.ReadLine());
                  Console.Write("Enter the color of the car:");
                  string color= Console.ReadLine();
                  Console.Write("Enter the price:");
                  double price = double.Parse(Console.ReadLine());
                Console.Write("Enter the availability(available/sold):");
                string status = Console.ReadLine();
                status = status.ToLower();  
                  List[nrel] = new Car(regno,  name, year, color,price,status);
                nrel++;
                Console.WriteLine("The car has been added successfully");

            }
            Console.WriteLine();
        }
        public void DisplayAvailable()
        {
            if (nrel == 0)
            {
                Console.WriteLine("No cars available");
            }
            else
            {
                for (int i = 0; i < nrel; i++) 
                {
                    if (List[i].Getstatus()=="available") 
                    {
                        List[i].Displaycar();
                    }
                }
                Console.WriteLine();
            }
        }
        public void DisplayAll()
        {
            if (nrel == 0)
            {
                Console.WriteLine("No cars available");
            }
            else
            {
                for (int i = 0; i < nrel; i++) 
                {
                    List[i].DisplayALL();
                }
                Console.WriteLine();
                
            }
          }
        public void WriteData() 
        {
            StreamWriter wr = new StreamWriter("carDataoutput.txt");
            for (int i = 0; i < nrel; i++)
            {
                wr.Write(List[i].GetRegistration() + ",");
                wr.Write(List[i].GetModelName() + ",");
                wr.Write(List[i].GetYear() + ",");
                wr.Write(List[i].GetColor() + ",");
                wr.Write(List[i].GetPrice() + ",");
                wr.WriteLine(List[i].Getstatus());
            
            } 
            wr.Close();
        }
       
    }
}

    


