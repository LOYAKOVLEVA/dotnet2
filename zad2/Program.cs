// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

if(b % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}