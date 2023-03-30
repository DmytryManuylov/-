// Вводим число N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

// Выводим все четные числа от 1 до N
for (int i = 2; i < N; i+= 2)
{
    Console.Write(i + " ");
}
Console.WriteLine();
