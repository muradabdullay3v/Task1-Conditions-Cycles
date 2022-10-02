Console.Write("Input a number : ");
int number  = int.Parse(Console.ReadLine());
int newnumber = 0;
while (number > 0)
{
    newnumber *= 10;
    newnumber += number % 10;
    number /= 10;
}

Console.WriteLine(newnumber);