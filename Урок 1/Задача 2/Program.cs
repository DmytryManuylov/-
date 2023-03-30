// Вводим два числа
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

// Сравниваем их и выводим результат
if (a > b)
{
    Console.WriteLine("max = " + a);
}
else if (a < b)
{св
    Console.WriteLine("max = " + b);
}
else
{
    Console.WriteLine("Числа равны");
}