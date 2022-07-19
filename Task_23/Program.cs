// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Таблица кубов чисел от 1 до (N)");
Console.Write("Ввидите число (N): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1)
{
    for (int num = 1; num <= n; num++)
    {
        double result = Math.Pow(num, 3); Console.WriteLine($"{num} -> {result}");
    }
}
else Console.WriteLine("Введено не верное значение");