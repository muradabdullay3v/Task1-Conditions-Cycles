Console.Write("Input n : ");
int n = int.Parse(Console.ReadLine());
double sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += 1 + (1 / Math.Pow(i, 2));
}

Console.WriteLine(sum);