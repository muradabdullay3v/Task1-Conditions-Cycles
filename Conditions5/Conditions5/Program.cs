string[] firstnumbers = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty" , "ninety"};
string[] secondnumbers = { "one" , "two" , "three" , "four" , "five" , "six" , "seven" , "eight" , "nine" };
Console.Write("Type a number: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 && number > 9)
{
    switch (number)
    {
        case 10:
            Console.WriteLine("Ten");
            break;
        case 11:
            Console.WriteLine("Eleven");
            break;
        case 12:
            Console.WriteLine("Twelve");
            break;
        case 13:
            Console.WriteLine("Thirteen");
            break;
        case 14:
            Console.WriteLine("Fourteen");
            break;
        case 15:
            Console.WriteLine("Fifteen");
            break;
        case 16:
            Console.WriteLine("Sixteen");
            break;
        case 17:
            Console.WriteLine("Seventeen");
            break;
        case 18:
            Console.WriteLine("Eighteen");
            break;
        case 19:
            Console.WriteLine("Nineteen");
            break;
        default:
            int firstnumber = number / 10;
            int secondnumber = number % 10;
            if (firstnumber > 0 && secondnumber > 0)
            {
                Console.WriteLine(firstnumbers[firstnumber - 2].ToString() + " " + secondnumbers[secondnumber - 1].ToString());
            }
            else if(firstnumber > 0 && secondnumber == 0)
            {
                Console.WriteLine(firstnumbers[firstnumber - 2]);
            }
            break;
    }
}

else
{
    Console.WriteLine("Number must be less than 100 and more than 9 :D");
}
