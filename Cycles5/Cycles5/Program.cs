Console.Write("Input a : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b : ");
int b = int.Parse(Console.ReadLine());
int sum = 0;
if (a > b)
{
    for (int i = b; i <= a; i++)
    {
        if (i % 7 == 0 )
        {
            sum += i;
        }
    }
}

else
{
    for (int i = a; i <= b; i++)
    {
        if (i % 7 == 0)
        {
            sum += i;
        }
    }
}

Console.WriteLine(sum);