// Задача 8 из ДЗ по первому семинару
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int index = 0;
    int count = 0;
    int find = (N / 2);

Console.WriteLine("Все четные числа от 1 до введенного числа: ");

    while (index < find)
    {
        count = count + 2;
        Console.Write(count);
        Console.Write(" | ");
        index = index + 1;
    }
    