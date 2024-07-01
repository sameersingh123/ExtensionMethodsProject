using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    internal class TestExtMethods
    {
        static void Main()
        {
           Program p=new Program();
            p.Test1();                     //calling the method of the class Program
            p.Test2();
            p.Test3(10);                   //calling the extension method of the class Program which is defined in the StatClass

            int i=new Int32();            //calling the extension method of the Int32 class which is defined in the ReviseStatClass
            Console.WriteLine(i.Factorial(5));

            //string s = new string();
            //Console.WriteLine(s.ToProper("sAmEEr sInGH"));


            string s = new String("sAmEEr sInGH");
            Console.WriteLine(s.ToProper(s));
        }
    }
}
