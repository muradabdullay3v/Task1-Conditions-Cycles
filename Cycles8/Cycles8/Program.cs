Console.Write("Input a: ");
int a = int.Parse(Console.ReadLine());
int number = 0;
if (a > 0)
{
    for (int i = 1; i*i*i <= a; i++)
    {
        number = i;
    }
    Console.WriteLine(number);
}

else
{
    Console.WriteLine("POSITIVEE I SAID!!!");
}