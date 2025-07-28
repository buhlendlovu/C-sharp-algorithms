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
                wr.WriteLine(List[i].GetRegistration() + ",");
                wr.WriteLine(List[i].GetModelName() + ",");
                wr.WriteLine(List[i].GetYear() + ",");
                wr.WriteLine(List[i].GetColor() + ",");
                wr.WriteLine(List[i].GetPrice() + ",");
                wr.WriteLine(List[i].Getstatus());
            
            } 
            wr.Close();
        }
        public int Findcar(string wanted) 
        {
            //string wanted;
            for (int i=0;i<nrel;i++)
            {
                if (List[i].GetRegistration() == wanted)
                {
                    return i;


                }
            }
            return -1;
        }
        public void DeleteCar()
        {
            Console.Write("Enter the registration number of the car you want:");
            string reg = Console.ReadLine();
            reg=reg.ToUpper();
            int pos = Findcar(reg);
            for (int i=pos;i<nrel-2; i++) 
            {
                List[i] = List[i + 1];
                
            }
            nrel--;

            Console.WriteLine("The car has been deleted successfully");

            ;
        }
        public void sellcar()
        {
            Console.Write("Enter the registration number of the car you want:");
            string Reg = Console.ReadLine();
            Reg = Reg.ToUpper();
            int pos = Findcar(Reg);
            if (pos==-1) {Console.WriteLine(); }

            else
            {
                for (int i = 0; i < nrel; i++)
                {
                    if (List[i].GetRegistration() == Reg)
                    {
                        List[pos].setStatus("sold");
                        Console.WriteLine("The car has been sold");

                    }

                }
            }
        
        }
        public void Decrease() 
        {
            Console.Write("Enter the registration No:");
            string reg = Console.ReadLine();
            reg = reg.ToUpper();
            int pos= Findcar(reg);
            for (int i = 0; i < nrel; i++) 
            {
                if (List[i].GetRegistration() == reg) 
                {
                    Console.Write("Enter the percentage decrease:");
                    double percentage= double.Parse(Console.ReadLine());
                double Amount= List[i].GetPrice()*percentage;
                    List[pos].DecreasePrice(Amount);
                    Console.WriteLine("The price is successfully decreased");
                
                }
            
            }
        
        }
        public void DisplayAbove50K() 
        {
            Console.WriteLine("List of cars that are not cheap");
            Console.WriteLine("\n");
            for (int i=0;i<nrel;i++) 
            {
                if (List[i].Ischeap() == true) 
                {
                    List[i].Displaycar();
                }
            }
        
        }
        public void Displaybelow50()
        {
            Console.WriteLine("List of cars that are cheap");
            Console.WriteLine("\n");
            for (int i = 0; i < nrel; i++)
            {
                if (List[i].Ischeap() == false)
                {
                    List[i].Displaycar();
                }
            }

        }
    }
}

    


