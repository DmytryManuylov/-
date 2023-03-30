// Вводим число
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

// Находим третью цифру или сообщаем, что ее нет
if (n >= 100)
{
    int third = (n / 100) % 10;
    Console.WriteLine("Третья цифра: " + third);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}