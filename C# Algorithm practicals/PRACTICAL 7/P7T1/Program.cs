using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace P7T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassengerList passList = new PassengerList();

            DisplayOptions(passList);
            int choice = int.Parse(ReadLine());
            ProcessOption(passList, choice);

            while(choice != 6)
            {
                DisplayOptions(passList);
                choice = int.Parse(ReadLine());
                ProcessOption(passList,choice);
            }
            ReadLine();
        }
        static void DisplayOptions(PassengerList passList)
        {
            WriteLine("Choose one of the following options: ");
            WriteLine("1. Add a new passenger.");
            WriteLine("2. Delete a passenger.");
            WriteLine("3. Display passenger details.");
            WriteLine("4. Display passengers for a specific route.");
            WriteLine("5. Display all passengers");
            WriteLine("6. Save data and quit.");
            Write("Enter your choice: ");
        }
        static void ProcessOption(PassengerList passList, int choice)
        {
            WriteLine();
            switch(choice)
            {
                case (1):
                    AddPassenger(passList);
                    WriteLine();
                    break;
                case (2):
                    DeletePassenger(passList);
                    WriteLine();
                    break;
                case (3):
                    passList.DisplayOne();
                    WriteLine();
                    break;
                case (4):
                    passList.DisplayRoute();
                    WriteLine();
                    break;
                case (5):
                    passList.DisplayAll();
                    WriteLine();
                    break;
                case (6):
                    WriteLine("Data is being saved. Goodbye...");
                    passList.Close();
                    break;
                default:
                    WriteLine("Invalid choice, please try again.");
                    WriteLine();

                    break;
            }
        }
        static void AddPassenger(PassengerList passList)
        {
            Write("Enter passenger number: ");
            int passNum = int.Parse(ReadLine());
            Write("Enter passenger's surname: ");
            string surname = ReadLine();
            Write("Enter passenger's initials: ");
            string initials = ReadLine().ToUpper();
            Write("Enter the route used by passenger (GQ-UTH/GQ-MAK/GQ-JHB/GQ-DBN/JHB-GQ): ");
            string route = ReadLine().ToUpper();
            Write("Enter date of depature (yyyy/mm/dd): ");
            string date = ReadLine();
            Write("Enter the ticket amount: ");
            double amount = double.Parse(ReadLine());
            Write("Enter the passenger's amount status (paid/outstanding): ");
            string status = ReadLine().ToLower();
            Passenger newPass = new Passenger(passNum, surname, initials, route, date, amount, status);
            passList.AddPassenger(newPass);
            WriteLine("The passenger was successfully added.");
        }
        static void DeletePassenger(PassengerList passList)
        {
            Write("Enter the passenger number of the passenger that needs to be deleted: ");
            int wanted = int.Parse(ReadLine());
            int pos = passList.FindPass(wanted);
            
            if (pos == 0)
                WriteLine("The passenger was not found.");
            else
            {
                passList.DeletePassenger(pos);
                WriteLine("The passenger was deleted.");
            }
        }
        
    }
}
