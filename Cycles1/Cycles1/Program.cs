Console.Write("Input a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b: ");
int b = int.Parse(Console.ReadLine());
int power = a;
for (int i = 1; i < b; i++)
{
    a = a * power;
}
if (b == 0)
{
    a = 1;
}

Console.WriteLine(a);