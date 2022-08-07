// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введи количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numbers, int min, int max)
{
    int[] random = new int[numbers];
    int sum = 0;
    Console.Write("Получившийся массив: ");

    for (int i = 0; i < random.Length; i++)
    {
        random[i] = new Random().Next(min, max);

        Console.Write(random[i] + " ");

        if (i % 2 != 1)
        {
            sum = sum + random[i];
        }
    }
    return sum;
}

int random = RandomNumbers(numbers, 1, 100);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {random}");