// На вход подается 3 числа
// на выходе максимальное из них

Console.WriteLine("Введите первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int n3 = int.Parse(Console.ReadLine());
if (n1 > n2 && n1 > n3)
Console.WriteLine("Максимальное число = " + n1); 
else if (n2 > n3)
Console.WriteLine("Максимальное число = " + n2); 
else
Console.WriteLine("Максимальное число = " + n3); 
Console.ReadLine();

