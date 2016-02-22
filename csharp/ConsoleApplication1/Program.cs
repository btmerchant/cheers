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
            string userName = "";
            string birthday = "";
            Console.WriteLine("What is your userName?");
            userName = readKeyboard();
           
            //userName = userName.TrimEnd();
            Console.WriteLine("\n> " + userName + "\n");
            Console.WriteLine("What is your Birthday (mm/dd)?\n");
            birthday = readKeyboard();
           
            Console.WriteLine("> {0}\n", birthday);
            string userNameS = userName.ToString();
            int userNameI = userNameS.Length;
            for (int i = 0; i < userNameI - 1; i++)
                {
                    bool specialCharacterTestResult = TestForSpecialCharacters(userNameS[i]);
                    if (specialCharacterTestResult)
                    {
                        Console.WriteLine("Give me an..    " + userNameS[i]);
                    }
                    else
                    {
                        Console.WriteLine("Give me a...    " + userNameS[i]);
                    }
                }
            string s = String.Format("\n {0} is Grand!\n", userName);
            Console.WriteLine(s);
            int timeToBirthday = calcBirthday(birthday);
                if (timeToBirthday == 0)
                {
                Console.WriteLine("Happy Birthday " + userName + "!!");
                }
                else
                {                   
                    Console.WriteLine("Your Birthday is " + timeToBirthday + " days away!\n");
                }
            
            Console.WriteLine("Press any key to exit");         
            Console.ReadKey();
            }

        public static string readKeyboard()
        {
            ConsoleKeyInfo key;
            string keyData = "";
            do
            {
                key = Console.ReadKey(true);
                keyData += key.KeyChar;
            }
            while (key.Key != ConsoleKey.Enter);
            return keyData;
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
            try
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
            catch (System.FormatException)
            {
                Console.WriteLine("Incorect Birthdate Format");
                return 0;
            }
        }
    }
}
