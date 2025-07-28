using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P7T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passengerlist list = new Passengerlist();

            IndexList indexList = new IndexList();
            list.BuildIndex(indexList);
            
            int count = list.Count();
            int res;

            do
            {
                res = Menu();
                switch (res)
                {
                    case 1: Add(list,indexList); break;
                    case 2: Delete(list,indexList,count); break;
                    case 3: Display1(indexList,count,list); break;
                    case 4: DisplayRouted(indexList,list); break;
                    case 5: Displayall(list,count,indexList); break;
                    case 6: Update(list,count,indexList); break;
                    case 7: DisplayallIndex(list,count,indexList); break;
                    case 8: list.WriteData();
                        Console.WriteLine("Thank you and Byee");
                        break;
                    default:
                        Console.WriteLine("INVALID ENTRY ");
                        break;
                }

               
            } while (res != 8);


            Console.ReadLine();
        }
        static int Menu()
        {
            Console.WriteLine("Choose one of the following options :");
            Console.WriteLine("1. Add a new passenger ");
            Console.WriteLine("2. Delete a passenger ");
            Console.WriteLine("3. Display passenger details ");
            Console.WriteLine("4. Display passenger for route ");
            Console.WriteLine("5. Display all passengers");
            Console.WriteLine("6. Do booking updates");
            Console.WriteLine("7. Display all index objects");
            Console.WriteLine("8. Save data and quit");
            Console.Write("Choice :");
            int res = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return res;
        }
       
        static void Add(Passengerlist list,IndexList indexlist)
        {
            int passnum;
            string surname;
            string initials;
            string route;
            string date;
            double amount;
            string status;
            string res;
            Console.Write("Enter passenger Surname :");
            surname = Console.ReadLine();
            Console.Write("Enter passenger Initials :");
            initials = Console.ReadLine().ToUpper();
            Console.Write("Enter passenger number :");
            passnum = int.Parse(Console.ReadLine());
            Console.Write("Enter passenger route :");
            route = Console.ReadLine().ToUpper();
            Console.Write("Enter travel date:");
            date = Console.ReadLine();
            Console.Write("Enter travel costs :");
            amount = double.Parse(Console.ReadLine());
            Console.Write("Enter passenger status (P > Paid and O > Outstanding):");
            res = Console.ReadLine().ToUpper();
            if (res == "P")
            {
              status = "paid";
            }
            else
            {
                status = "outstanding";
            }

            Passenger newP = new Passenger(passnum,surname,initials,route,date,amount,status);

            list.Addnew(newP,indexlist);
            
            Console.WriteLine("Passenger added success");
            Console.WriteLine();
        }
        static void Delete(Passengerlist list,IndexList indexlist,int count)
        {
            if (count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                int num, pos;

                Console.Write("Enter passenger number :");
                num = int.Parse(Console.ReadLine());

                pos = indexlist.FindIndex(num);
                pos--;
                 

                if (pos < 0)
                {
                    Console.WriteLine("Passenger not found");
                }
                else
                {
                    Index newIn = indexlist.Getpassenger(pos);
                    int position = newIn.Getpasspos();

                    list.Delete(position);

                    indexlist.DeleteIndex(pos);


                    Console.WriteLine("Pasenger deleted");

                }
            }
            Console.WriteLine();
        }
        static void Display1(IndexList index,int count,Passengerlist list)
        {
            int num, pos;
            
            if (count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Enter passenger number :");
                num = int.Parse(Console.ReadLine());
                pos = index.FindIndex(num);
                pos--;
                
                if (pos < 0)
                {
                    Console.WriteLine("Passenger not found");
                }
                else
                {
                    Index newIn = index.Getpassenger(pos);
                    int position = newIn.Getpasspos();

                    Passenger pass = list.Getpassenger(position);

                    pass.Display1();
                }

            }
            Console.WriteLine();
        }
        static void DisplayRouted(IndexList index,Passengerlist list)
        {
            string wanted;
            if (list.Count() == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Enter the route you are looking for :");
                wanted = Console.ReadLine().ToUpper();

                
                index.DisplayRoute(wanted,list);
            }
            Console.WriteLine();
        }
        static void Displayall(Passengerlist list,int count,IndexList index)
        {
            if (count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                list.DisplayDetails();
            }
            Console.WriteLine();
        }
        static void DisplayallIndex(Passengerlist list, int count, IndexList index)
        {
            if (count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                index.DisplayAll();
               
            }
            Console.WriteLine();
        }
        static void Update(Passengerlist list,int count,IndexList index)
        {
            int wanted, pos;
            string status;
            if (count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Enter the passenger number you want to update :");
                wanted = int.Parse(Console.ReadLine());
                pos = index.FindIndex(wanted);
                pos--;
                if (pos < 0)
                {
                    Console.WriteLine("Passenger not found");
                }
                else
                {
                    Console.Write("Enter the status you want to set to (P > Paid and O > Outstanding) :");
                    string res = Console.ReadLine().ToUpper();
                    if (res == "P")
                    {
                        status = "paid";
                    }
                    else
                    {
                        status = "outstanding";
                    }
                    Index curIndex = index.Getpassenger(pos);
                    int position = curIndex.Getpasspos();

                    Passenger cur = list.Getpassenger(position);
                    cur.Setstatus(status);
                    Console.WriteLine("Status updated");
                }            
            }
            Console.WriteLine();
        }
        
    }
}
