using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        private T[] array;
        private int count;
        private int index = -1;

        public MyListEnumerator(T[] array, int count)
        {
            this.array = array;
            this.count = count;
        }

        public T Current => array[index];

        object IEnumerator.Current => Current;

        public void Dispose() { }
        public bool MoveNext()
        {
            return ++index < count;
        }

        public void Reset()
        {
            //index = -1;
        }
    }
}
