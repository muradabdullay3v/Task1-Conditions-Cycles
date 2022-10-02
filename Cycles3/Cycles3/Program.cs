Console.Write("Type a : ");
int a = int.Parse(Console.ReadLine());
for (int i = 1; i * i < a; i++)
{
    Console.WriteLine(i);
}