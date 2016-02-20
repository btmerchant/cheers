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
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("\nThanks for the input " + name + " Heres your Cheer!\n");
            var nameS = name.ToString();
            int nameI = nameS.Length;
            for (int i = 0; i < nameI; i++)
                {
                bool specialCharacterTestResult = TestForSpecialCharacters(nameS[i]);
                    if (specialCharacterTestResult)
                    {
                        Console.WriteLine("Give me an..    " + nameS[i]);
                    }
                    else
                    {
                        Console.WriteLine("Give me  a..    " + nameS[i]);
                    }
                }
            Console.WriteLine("\n{0}.. is Grand!\n", name);
            Console.WriteLine("Press any key to exit");         
            Console.ReadKey();
            }

        public static bool TestForSpecialCharacters(char testCharacter)
        {
            string specialCaracters = "aefhoihlmnrsx";
            string charUpper = testCharacter.ToString();
            charUpper = charUpper.ToLower();
            bool b = false;
                if (specialCaracters.Contains(charUpper))
                { b = true; }
                else
                { b = false; }
            return b;
        }
    }
}
