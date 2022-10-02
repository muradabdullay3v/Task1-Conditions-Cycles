using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions7.Options
{
    public static class Option
    {
        public static void FirstOption()
        {
            bool isThreeDigit = false;
            int number = 0;
            do
            {
               Console.Write("Input 3-digit number: ");
               number = int.Parse(Console.ReadLine());
                if(number > 99 && number < 1000)
                {
                    isThreeDigit = true;
                }
                else
                {
                    Console.WriteLine("3-digit number required!");
                }
            } while (!isThreeDigit);
            int first = number / 100;
            int second = number / 10 % 10;
            int third = number % 10;
            Console.Clear();
            if (number * number == Math.Pow((first + second + third), 3))
            {
                Console.WriteLine("Yes they are equal\n" + number * number + " is equal to " + Math.Pow((first + second + third), 3));
            }
            else
            {
                Console.WriteLine("They are not equal\n" + number * number + " is not equal to " + Math.Pow((first + second + third), 3));
            }
        }
        public static void SecondOption()
        {
            bool isFourDigit = false;
            int number = 0;
            do
            {
                Console.Write("Type 4 digit number: ");
                number = int.Parse(Console.ReadLine());
                if (number > 999 & number < 10000)
                {
                    isFourDigit = true;
                }
                else
                {
                    Console.WriteLine("4-digit number required!");
                }
            } while (!isFourDigit);
            int first = number / 1000;
            int second = number / 100 % 10;
            int third = number / 10 % 10;
            int fourth = number % 10;
            Console.Clear();
            if (first + second == third + fourth)
            {
                Console.WriteLine($"Yeah {first + second} is equal to {third + fourth}");
            }
            else
            {
                Console.WriteLine($"No {first + second} is not equal to {third + fourth}");
            }
        }

        public static void ThirdOption()
        {
            bool isThreeDigit = false;
            int number = 0;
            do
            {
                Console.Write("Type 3-digit number: ");
                number = int.Parse(Console.ReadLine());
                if (number > 99 && number < 1000)
                {
                    isThreeDigit = true;
                }
                else
                {
                    Console.WriteLine("3-digit number required!\n");
                }
            } while (!isThreeDigit);
            int first = number / 100;
            int second = number / 10 % 10;
            int third = number % 10;
            Console.Clear();
            if (first == second || second == third || first == third)
            {
                Console.WriteLine("Yes number have similar digits");
            }
            else
            {
                Console.WriteLine("No, number doesn't have similar digits :(");
            }
        }

        public static void FourthOption()
        {
            Console.Write("Type a float number: ");
            string number = Console.ReadLine();
            string afterComma = number.Split('.')[1];
            if (afterComma[0] == '0' || afterComma[1] == '0' || afterComma[2] == '0')
            {
                Console.WriteLine("Yes first 3 digits after comma contains 0.");
            }
            else
            {
                Console.WriteLine("There is no zeros :(");
            }
        }

        public static void ShowOptions()
        {
            Console.WriteLine("Options :");
            Console.WriteLine("1.Take a 3-digit number as input, and say if square of this number equals sum of all it’s digits to the power of 3.");
            Console.WriteLine("2.Take a 4-digit number and say if sum of first two digits equals sum of last 2 digits.");
            Console.WriteLine("3.Take a 3-digit number as input. Say if there any 2 similar digits in it.");
            Console.WriteLine("4.Take a float number. Say if first 3 digits after comma contains 0.");
            Console.WriteLine("5.Exit.");
            Console.Write("Your option : ");
        }
    }
}
