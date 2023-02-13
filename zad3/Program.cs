// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int a = Convert.ToInt32(Console.ReadLine());

if (i > a)
{
    Console.WriteLine("max = " + i);
}
else if (a > i)
{
    Console.WriteLine("max = "+ a);
}