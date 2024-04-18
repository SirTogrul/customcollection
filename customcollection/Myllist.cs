using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace customcollection
{
    public class Mylist<T>
    {
     private int _count;
        public int  capacity;
        public List<T> items=new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> FindAll(Predicate<T> predicate)
        {
           return items.FindAll(predicate);
        }
        public List<T> Find(Predicate<T> predicate,int roomcapacity)
        {
            return items.Find(x => x.capacity == roomcapacity);
        }
    }
}
