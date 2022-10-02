Console.Write("Input a : ");
int a = int.Parse(Console.ReadLine());
int evensum = 0;
int oddsum = 0;
int temp = 0;
int number = 0;
for (int i = 1; i <= a; i++)
{
    number = i;
    while (number > 0)
    {
        temp = number % 10;
        number = number / 10;
        if (temp % 2 == 0)
        {
            evensum += temp;
        }
        else
        {
            oddsum += temp;
        }
    }

    if (evensum > oddsum)
    {
        Console.WriteLine(i);
    }
    oddsum = 0;
    evensum = 0;
}
