using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTenFeatures
{
    public interface Interface1
    {
        void add(int x, int y);
         void multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Multiply of two numbers:"+ result );
        }
    }

    public class class1 : Interface1
    {
        public void add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("from class 1 Addition of two numbers: "+result);
        }
    }

    public class class2 : Interface1
    {
        public void add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("from class 2 Addition of two numbers: "+result);
        }
    }
}
