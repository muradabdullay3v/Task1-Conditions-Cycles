using System;
using Conditions7.Options;
namespace Conditions7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int option = 0;
            string again = string.Empty;
            do
            {
                Option.ShowOptions();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Option.FirstOption();
                        break;
                    case 2:
                        Option.SecondOption();
                        break;
                    case 3:
                        Option.ThirdOption();
                        break;
                    case 4:
                        Option.FourthOption();
                        break;
                    case 5:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("There is no such option!\nPlease try again mate :D\n");
                        break;
                }
                Console.WriteLine("\nDo u wanna try again?");
                Console.Write("\nIf yes press y else press any ohter button! : ");
                again = Console.ReadLine();
                Console.Clear();
            } while (again == "y" || again == "Y");
        }
    }
}