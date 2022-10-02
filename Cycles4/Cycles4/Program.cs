Console.Write("Input a number : ");
int a = int.Parse(Console.ReadLine());
int d = 0;
for (int i = 1; i < a; i++)
{
    if (a % i == 0)
    {
        d = i;
    }
}

Console.WriteLine(d);