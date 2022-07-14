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
    if (N > 100 && N < 1000)
    {
        int total = tres(N);

        int tres(int N)
        {
            int tres = N % 10;
            return tres;
        }

        Console.WriteLine("Третьей цифрой введенного числа является: ");
        Console.WriteLine(total);
    }

}
