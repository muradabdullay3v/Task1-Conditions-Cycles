Console.Write("Input a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b: ");
int b = int.Parse(Console.ReadLine());
int gcd = 0;
int remainder = 0;
if (a > b)
{
    while (a % b > 0)
    {
       remainder = a % b;
       a = b;
       b = remainder;
    }
    gcd = b;
}

else
{
    while (b % a > 0)
    {
        remainder = b % a;
        b = a;
        a = remainder;
    }
    gcd = a;
}

Console.WriteLine(gcd);