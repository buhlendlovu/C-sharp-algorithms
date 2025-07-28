using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prac_5
{
    internal class Car:IComparable
    {
        string regNum;
        string modelName;
        int year;
        string colour;
        double price;
        bool status;
        public Car( string regNum,string modelName,int year,string colour,double price,bool status) 
        {
            this.regNum = regNum;
            this.modelName = modelName;
            this.year = year;
            this.colour = colour;
            this.price = price;
            this.status = false;
        }
        public string GetregNum() 
        { 
            return regNum;
        }
        public string GetmodelName()
        {
            return modelName;
        }
        public int Getyear()
        { 
            return year;
        }
        public string GetColour()
        { 
            return colour;
        }
        public double Getprice()
        {
            return price;
        }
        public bool GetStatus()
        {
            if (status == false)
            {
                WriteLine("Sold");
            }
            else
            {
                WriteLine("Available");
            }
            return status;
        }
        public void SetPrice(double price) 
        {
            this.price = price;
        }
        public void SetStatus(bool status)
        { 
            this.status = status;
        }
        public void DisplayCar() 
        {
            WriteLine("Registration Number: {0}\nPrice Number: {1}",regNum,price);
        }
        public void DisplayDetailCar() 
        {
            WriteLine("Registration Number:{0}\nModelName:{1}\n Year:{2}\nColour:{3}\nPrice Number:{4}\n Status{5}", regNum, modelName, year, colour, price, status);
        }
        int IComparable.CompareTo(object obj)
        { 
            Car temp=(Car)obj;
            return string.Compare(this.regNum, temp.regNum, StringComparison.Ordinal);
        }
    }
}
