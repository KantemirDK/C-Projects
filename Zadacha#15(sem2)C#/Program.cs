// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели от 1 до 7: ");
int N = Convert.ToInt16(Console.ReadLine());

if (N > 5 && N < 8)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}

switch (N)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7:Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Ошибка. Повторите операцию и введите значение от 1 до 7"); break;
}