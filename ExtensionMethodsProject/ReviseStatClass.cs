using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    internal static class ReviseStatClass
    {
        public static void Test4(this Program p, int i)      //Extension method
        {
            Console.WriteLine("Method 4 called. "+i);
        }
        public static int FactorialInt(this int a, int x)      //Extension method
        {
            int f = 1;
            for(int i = 1; i <= x; i++)
            {
                f=f * i;
            }
            return f;
        }
        
        static void Main()
        {
            Program p=new Program();
            p.Test1();
            p.Test2();
            p.Test4(10);
            int i=new int();
            Console.WriteLine(i.FactorialInt(6)); 
        }
    }
}
