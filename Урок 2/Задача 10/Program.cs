// Вводим трехзначное число
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

// Находим вторую цифру и выводим результат
int second = (n / 10) % 10;
Console.WriteLine("Вторая цифра: " + second);