Console.Write("Input x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Input y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Input radius: ");
int r = int.Parse(Console.ReadLine());
if (x*x + y+y > r*r)
{
    Console.WriteLine("Outside");
}

else if (x*x + y*y < r*r)
{
    Console.WriteLine("Inside");
}

else
{
    Console.WriteLine("On the circle");
}