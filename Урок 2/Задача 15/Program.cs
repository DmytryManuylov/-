// Вводим цифру, обозначающую день недели
Console.WriteLine("Введите цифру от 1 до 7: ");
int day = int.Parse(Console.ReadLine());

// Проверяем, является ли этот день выходным и выводим результат
if (day == 6 || day == 7)
{
    Console.WriteLine("да");
}
else if (day >= 1 && day <= 5)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Неверный ввод");
}