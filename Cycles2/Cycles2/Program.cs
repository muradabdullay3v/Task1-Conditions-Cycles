Console.Write("Input a: ");
int a = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % a == 0)
    {
        count++;
    }
}

Console.WriteLine(count);