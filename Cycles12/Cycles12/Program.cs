Console.Write("Input a :");
string a = Console.ReadLine();
Console.Write("Input b : ");
string b = Console.ReadLine();
bool isSame = false;
for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j])
        {
            isSame = true;
        }
    }
}

if (!isSame)
{
    Console.WriteLine("No!");
}

else
{
    Console.WriteLine("Yesss!");
}