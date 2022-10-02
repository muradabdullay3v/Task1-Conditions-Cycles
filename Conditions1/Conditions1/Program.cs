Console.WriteLine("Input a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input b:");
int b = int.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine(a+b);
}
else if (a == b)
{
    Console.WriteLine(a*b);
}

else
{
    Console.WriteLine(a-b);
}