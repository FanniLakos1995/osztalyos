using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    public class B : A
    {
        protected void S4()
        {
            Console.WriteLine("A::V1");
            V1();

        }

        public void S5()
        {
            S3();
        }

        protected void S3()
        {
            
        }

        public virtual void V2()
        {
            V1();
        }

        protected virtual void V1()
        {
            S5();
        }
    }
}