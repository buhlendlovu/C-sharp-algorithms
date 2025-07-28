using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7T1
{
    internal class IndexList
    {

        ArrayList Indexlist;
        
        public IndexList() 
        {
            Indexlist = new ArrayList();
        }
        
        public void AddIndex(Index index)
        {
          Indexlist.Add(index);
          
        }
        public int FindIndex(int wanted)
        {
            int pos;
            pos = BinerySearch(wanted);

            return pos+1;
        }
        public void DeleteIndex(int pos)
        {
            Indexlist.RemoveAt(pos);
        }
        public int Count()
        {
            return Indexlist.Count;
        }
        public void BubbleSort()
        {
            for (int pass = 1; pass < Indexlist.Count; pass++)
            {
                for (int i = 1; i <= Indexlist.Count-pass; i++)
                {
                    Index first = (Index)Indexlist[i-1];
                    Index second = (Index)Indexlist[i];

                    if(first.Getpassnum() > second.Getpassnum())
                    {
                        swop(i - 1, i);
                    }
                }
            }
        }
        private void swop(int num1,int num2)
        {
            Index temp = (Index)Indexlist[num2];
            Indexlist[num2] = Indexlist[num1];
            Indexlist[num1] = temp;
        }
        public void DisplayAll()
        {
            
            for (int i = 0; i <Indexlist.Count; i++)
            {
                Index cur = (Index)Indexlist[i];
                cur.Display(i+1);
            }
        }
       
        public Index Getpassenger(int wanted)

        {
            Index NewIndex = (Index)Indexlist[wanted];

            return NewIndex;
        }
        public void DisplayRoute(string wanted,Passengerlist list)
        {
            string finds;
            for (int i = 0; i < Indexlist.Count; i++)
            {
                Passenger current = list.Getpassenger(i);

                finds = current.GetRoute();
                if (wanted == finds)
                {
                    current.Display1();
                }
            }
        }
        private int BinerySearch(int wanted)
        {
            int first = 0;
            int last = Indexlist.Count - 1;
            int mid;

            while(first <= last)
            {
                mid = (first + last) / 2;


                Index cur = (Index)Indexlist[mid];

                if (wanted == cur.Getpassnum())
                {
                    return mid;
                }
                else if (wanted > cur.Getpassnum())
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
            return -1;
        }
       
    }
}
