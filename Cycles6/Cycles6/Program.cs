Console.WriteLine("My Fibonacci starts that way 0 1 1 ....");
Console.Write("Input a : ");
int a = int.Parse(Console.ReadLine());
int n1 = 0;
int n2 = 1;
int n3 = 0;
if (a == 1)
{
    Console.WriteLine(n1);
}

else if (a == 2)
{
    Console.WriteLine(n2);
}

else
{
    for (int i = 2; i < a; i++)
    {
        n3 = n1 + n2;
        n1 = n2;
        n2 = n3;
    }



    Console.WriteLine(n3);
}

