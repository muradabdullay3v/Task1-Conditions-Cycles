Console.WriteLine("Input x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Input y:");
int y = int.Parse(Console.ReadLine());
if(x>0 && y > 0)
{
    Console.WriteLine("I quarter");
}

else if(x<0 && y > 0)
{
    Console.WriteLine("II quarter");
}

else if (x<0 && y<0)
{
    Console.WriteLine("III quarter");
}

else if (x>0 && y<0)
{
    Console.WriteLine("IV quarter");
}

else
{
    Console.WriteLine("Out of Quarter");
}