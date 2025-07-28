 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace P5T1
{
    internal class Car
    {
        string RegNo;
        double Price;
        string ModelName;
        int year;
        string status;
        string color;
        bool cheap;
        double decreaseP;
        public Car(string RegNo, string ModelName , int year , string color, double Price,string status) 
        {
        this.RegNo = RegNo;
            this.Price = Price;
            this.ModelName = ModelName;
            this.year = year;
            this.status = status;
            this.color = color;
        
        }
        public bool Ischeap() 
        {
            if (Price > 50000.00) 
            {
                return true;
            }
            return false;
        
        }
        public void DecreasePrice(double Amount) 
        {
        Price -= Amount;
        }
        public string GetRegistration() { return RegNo; }
        public double GetPrice() { return Price; }
        public string GetModelName() { return ModelName; }
        public int GetYear() { return year; }
        public string GetColor() { return color; }
        public string Getstatus() 
        {
           
            return status;
        }
        public void setStatus(string S) 
        {
        
        status = S;
        }
        
        public void Displaycar() 
        {
        Console.WriteLine("Registration number: {0} , Price: {1}",RegNo,Price);
        }
        public void DisplayALL() 
        {
            Console.WriteLine("Registration number; {0} ,Model: {1}, Year: {2}, color: {3},Price: {4}, status: {5}",RegNo,ModelName,year,color, Price, status );
        
        }

    }
}
