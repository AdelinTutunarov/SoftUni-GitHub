using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] array;
        private int index = 0;
        public MyList()
        {
             array = new T[1000];
        }

        public void Add(T element)
        {
            array[index++] = element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(array, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
