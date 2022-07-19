// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine();

void Number(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine("Введённое значение является палиндромом");
    }
    else Console.WriteLine("Введённое значение не является палиндромом");
}

if (number!.Length == 5)
{
    Number(number);
}
else Console.WriteLine("Введённое значение не является пятизначным. Пожалуйста, введите пятизначное число");