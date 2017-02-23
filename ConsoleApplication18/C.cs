using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    public class C : B
    {
        public void S6()
        {
            Console.WriteLine("A::V1");
            V1();
        }

        public void S7()
        {
            Console.WriteLine("B::V2");
            V2();
        }
    }
}