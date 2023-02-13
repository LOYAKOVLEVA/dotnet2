Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= a; i ++)
{
    if (i % 2 == 0 && i != 0)
    {
        Console.WriteLine(i);
    }
}

