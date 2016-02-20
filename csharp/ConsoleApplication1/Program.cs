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
            Console.WriteLine("Thank You " + name);
            var go = Console.ReadKey();
        }
    }
}
