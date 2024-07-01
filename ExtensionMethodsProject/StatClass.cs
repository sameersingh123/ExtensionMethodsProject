using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    internal static class StatClass
    {
        public static void Test3(this Program p,int x) //the paramter passed here(this Program p: binding parameter) is only for binding the extension method to the class and so in the main method we can call the extension method by the object of the class without passing the class object parameter
        {
            Console.WriteLine("Test3 Method "+x);
        }

        public static long Factorial(this Int32 a,int x)
        {
            int f = 1;
            for(int i = 1; i <= x; i++)
            {
                f=f * i;
            }
            return f;

        }

        public static string ToProper(this String s, string s1)
        {
            string[] words=s1.ToLower().Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }
            return string.Join(" ", words);
        }
    }
}
