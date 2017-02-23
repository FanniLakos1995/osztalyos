using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    public class D : B
    {
        public void S7()
        {
            Console.WriteLine("B::S3");
            S3();
        }

        public void S8()
        {
            Console.WriteLine("B::V2");
            V2();
        }

        protected virtual void V2()
        {
            S7();
        }
    }
}