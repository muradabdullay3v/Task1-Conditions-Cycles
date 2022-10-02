Console.WriteLine("Input a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Input c:");
int c = int.Parse(Console.ReadLine());
if (a > b && b>c)
{
    Console.WriteLine($"{a} {b} {c}");
}

else if (a>=c && c>=b)
{
    Console.WriteLine($"{a} {c} {b}");
}

else if (b>=a && a>=c)
{
    Console.WriteLine($"{b} {a} {c}");
}

else if (b >= c && c >= a)
{
    Console.WriteLine($"{b} {c} {a}");
}

else if (c >= a && a >= b)
{
    Console.WriteLine($"{c} {a} {b}");
}

else if (c >= b && b >= a)
{
    Console.WriteLine($"{c} {b} {a}");
}