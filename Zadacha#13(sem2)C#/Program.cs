// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 100)
{
    Console.WriteLine("Третью цифру найти невозможно, так как Вы ввели значение меньше 100");
}
else
{
    int n = N;
    int d = GetThirdDigit(n);

    int GetThirdDigit(int k)
    {
        while (k >= 1000) k /= 10;
        int d = k % 10;
        return d;
    }

    Console.WriteLine("Третьей цифрой введенного числа является: ");
    Console.WriteLine(d);
}

