using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    public class A
    {
        public void S1()
        {
            
            V1();
            
        }

        public void S2()
        {
            S1();
            
        }

        protected virtual void V1()
        {
            
            S3();
            
        }

        private void S3()
        {
            
        }
    }
}