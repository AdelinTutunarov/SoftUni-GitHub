using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T> where T : IComparable
    {
        public List<T> SomeThings { get; set; }
        public Box()
        {
            SomeThings = new List<T>();
        }

        public List<T> Swap(int index1, int index2)
        {
            T p = SomeThings[index1];
            SomeThings[index1] = SomeThings[index2];
            SomeThings[index2] = p;
            return SomeThings;
        }

        public int Count(T element)
        {
            int count = 0;
            foreach (var item in SomeThings)
            {
                if (item.CompareTo(element) > 0) count++;
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var thing in SomeThings)
            {
                sb.AppendLine($"{typeof(T)}: {thing}");
            }
            return sb.ToString();
        }
    }
}