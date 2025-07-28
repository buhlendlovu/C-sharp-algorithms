using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P6
{
    internal class Car:IComparable
    {
        string regNum;
        string modelname;
        int year;
        string colour;
        double price;
        bool status=false;
        public Car(string regNum, string modelname,int year,string colour,double price,bool status) 
        {
            this.regNum = regNum;
            this.modelname = modelname;
            this.year = year;
            this.colour = colour;
            this.price = price;
            this.status = status;   

        }

        public Car(string regNum, string modelname, int year, double price)
        {
            this.regNum = regNum;
            this.modelname = modelname;
            this.year = year;
            this.price = price;
        }

        public string GetRegNum()
        {
            return regNum; 
        }
        public string GetModelname() 
        {
            return modelname;
        }
        public int GetYear()
        {
            return year;
        }
        public string GetColour() 
        {
            return colour;
        }
        public double GetPrice()
        {
            return price;
        }
        public bool GetStatus() 
        {
            return status; 
        }
        public void SetPrice(double price)
        { 
            this.price = price;
        }
        public void SetStatus(bool S)
        {
            this.status = S;
        }
        public void DisplayCar()
        {
            WriteLine("Registration number {0} Price : {1}", regNum, price);
        }
        public void DisplayDetailCar()
        {
            WriteLine("Registration number {0} ModelName:{1} Year:{2} Colour :{3} Price :{4} Status : {5} ", regNum, modelname, year, colour, price, status);
        }
        public bool IsCheap()
        { 
            if (price>50000)
            {
                return true;
            }
            else
                return false;
        }
        public void DecreasePrice(double price)
        {
            price-=price;
        }
        int IComparable. CompareTo(object obj) 
        { 
            Car temp =(Car)obj;
            return string.Compare(this.regNum, temp.regNum, StringComparison.Ordinal);
        }
    }
}
