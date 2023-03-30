// Вводим три числа
Console.WriteLine("Введите три числа через пробел: ");
string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);

//Находим максимальное из них и выводим результат
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("max = " + max);