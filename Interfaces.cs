using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);

        //void Clear();
    }

    public static class BaseCollectionExtension
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach(var item in objects)
            {
                collection.Add(item);
            }
        }
    }
    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int count = 0;
        public BaseList(int intialCapacity)
        {
            items = new object[intialCapacity];
        }
        
        public void Add(object obj)
        {
            items[count] = obj; // реализация items в массиве
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
