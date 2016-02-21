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
            string name = Console.ReadLine();
            Console.WriteLine("\n> " + name + "\n");
            Console.WriteLine("What is your Birthday (mm/dd)?");
            string birthday = Console.ReadLine();
            Console.WriteLine("> {0}\n", birthday);
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
            int timeToBirthday = calcBirthday(birthday);
                if (timeToBirthday == 0)
                {
                Console.WriteLine("Happy Birthday " + name + "!!");
                }
                else
                {
                    
                    Console.WriteLine("Your Birthday is " + timeToBirthday + " days away!\n");
                }
            
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

        public static int calcBirthday(string birthday)
        {
            DateTime birthDate = DateTime.Parse(birthday);
            DateTime nextBday = new DateTime(DateTime.Now.Year, birthDate.Month, birthDate.Day);
            if (DateTime.Today > nextBday)
                {
                nextBday = nextBday.AddYears(1);    
                }
            int outDays = (nextBday - DateTime.Today).Days;         
            return outDays;
        }
    }
}
