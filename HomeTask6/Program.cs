// На вход подается число и выдает является ли оно чётным

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "Да, чётное" : "Нет, нечетное");

