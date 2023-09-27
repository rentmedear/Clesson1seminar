Console.WriteLine("Введите первое число: ");
int fnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int snumber = Convert.ToInt32(Console.ReadLine());

if (fnumber>snumber)
{
    Console.WriteLine($"max-> {fnumber}");
}
else
{
    Console.WriteLine($"max-> {snumber}");
}

