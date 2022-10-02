Console.Write("Input x : ");
int x = int.Parse(Console.ReadLine());
Console.Write("Input n : ");
int n = int.Parse(Console.ReadLine());
double firstsum = 0;
double firstnum = x;
double secondsum = 0;
int factorial = 1;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        firstnum *= x + i;
    }
    firstsum += 1 / firstnum;
}

Console.WriteLine(firstsum);

for (int i = 1; i <= n; i++)
{
    for (int f = 1; f <= i ; f++)
    {
        factorial *= f;
    }
    secondsum += Math.Pow(x,i) / factorial;
}

Console.WriteLine(secondsum);
