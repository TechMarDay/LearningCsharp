using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLearning
{
    //Generic
    //Syntax Class ClassName<T>
    internal class Printer<T>
    {
        public T data { get; set; }

        public Printer(T data)
        {
            this.data = data;
        }

        public void Print()
        {
            Console.WriteLine(data);
        }

        public T GetData()
        {
            return data;
        }
    }
}
