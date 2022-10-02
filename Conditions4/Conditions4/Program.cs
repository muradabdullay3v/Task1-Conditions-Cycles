Console.WriteLine("Input a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Input b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Input c:");
double c = double.Parse(Console.ReadLine());
double d = b * b - 4 * a * c;
double x1 = (-b + Math.Sqrt(d))/2*a;
double x2 = (-b - Math.Sqrt(d))/2*a;
if (d<0)
{
    Console.WriteLine("Negative root value error");
}
else {
    Console.WriteLine("x1 is " + x1 + "\nx2 is " + x2);
}
