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
            string bDayPerson = "";
            string birthday = "";
            Console.WriteLine("What is your Name?");
            bDayPerson = readKeyboard();
           
            //bDayPerson = bDayPerson.TrimEnd();
            Console.WriteLine("\n> " + bDayPerson + "\n"); // This works cause there is no char concat
            Console.WriteLine("What is your Birthday (mm/dd)?\n"); // This works cause there is no char concat
            birthday = readKeyboard();
           
            Console.WriteLine("> {0}\n", birthday);  // This works cause there is no char concat
            cheer(bDayPerson);
            //string s = (bDayPerson);  //This won't work as strings are imutable!
            //string b = (" is Grand!");
            //s = s + b;
            //Console.WriteLine(bDayPerson + " is Grand!"); //Nor this!
            //Console.WriteLine("{0} is Grand!", bDayPerson); //Nor this!   Imutable string
            // You must use stringBuilder!
            StringBuilder s = new StringBuilder("Yes");
            s.Append(bDayPerson);
            s.Append(" is Grand!\n");
            Console.WriteLine(s);
            happyBirthday(bDayPerson, birthday);
            
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

        public static void cheer(string personsName)
        {
            string p = personsName;
            int pi = personsName.Length;
            for (int i = 0; i < pi - 1; i++)
            {
                bool specialCharacterTestResult = TestForSpecialCharacters(p[i]);
                if (specialCharacterTestResult)
                {
                    Console.WriteLine("Give me an..    " + p[i]);
                }
                else
                {
                    Console.WriteLine("Give me a...    " + p[i]);
                }
            }
            Console.Write("\n");
        }

        public static void happyBirthday(string personsName, string birthday)
        {
            string p = personsName;
            string b = birthday;
            int timeToBirthday = calcBirthday(b);
            if (timeToBirthday == 0)
            {
                Console.WriteLine("Happy Birthday " + personsName + " !!\n"); //this is what you get ( !!py Birthday personsName)
            }
            else
            {
                Console.WriteLine("Your Birthday is " + timeToBirthday + " days away!\n");
            }

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
