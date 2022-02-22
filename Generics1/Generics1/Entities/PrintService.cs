using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1.Entities
{
    internal class PrintService<T>
    {
        public List<T> Values { get; set; }

        public PrintService()
        {
            Values = new List<T>();
        }

        public void AddValue(T value)
        {
            Values.Add(value);
        }

        public T First()
        {
            return Values[0];
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for(int i = 0; i < Values.Count - 1; i++)
            {
                sb.Append(Values[i] + ", ");
            }
            sb.Append(Values[Values.Count - 1] + "]");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(First());
        }

    }
}
