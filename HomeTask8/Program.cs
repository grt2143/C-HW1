// На вход подается число N
// На выходе показать все чётные от 1 до N

Console.WriteLine("Введите натуральное число");
int a = 1;
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
if (i % 2 == 0) 
{
Console.Write(i + " ");
}
}

