Console.Write("Input a number : ");
int a = int.Parse(Console.ReadLine());
int count = 0;
int temp = 0;
while (a > 0)
{
    temp = a % 10;
    if (a % 2 != 0)
    {
        count++;
    }
    a = a / 10;
}

Console.WriteLine(count);