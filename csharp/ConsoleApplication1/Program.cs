using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            var name = Console.ReadLine();
            var nameS = name.ToString();
            int nameI = nameS.Length;
            Console.WriteLine("Thank You " + name);
            for (int i = 0; i < nameI; i++)
                {
                bool vowelTestResult = TestForVowel(nameS[i]);
                    if (vowelTestResult)
                    {
                        Console.WriteLine("Giveme an " + nameS[i]);
                    }
                    else
                    {
                        Console.WriteLine("Giveme a " + nameS[i]);
                    }
                }
            Console.WriteLine("Press any key to exit");         
            var go = Console.ReadKey();
            }

        public static bool TestForVowel(char c)
        {
            string vowels = "aeio";
            bool b = false;
                if (vowels.Contains(c))
                { b = true; }
                else
                { b = false; }
            return b;
        }
    }
}
