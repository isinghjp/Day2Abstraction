using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
    class Abc
    {
        public void Fun1()
        {
            Console.WriteLine("Fun1 Invoked");
        }
        protected void Fun2()
        {
            Console.WriteLine("Fun2 Invoked");
        }
        private void Fun3() {
            Console.WriteLine("Fun3 Invoked");
        }
    }
}
