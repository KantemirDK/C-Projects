// Задача 10: Напишите программу, которая принимает на вход трёхзначное \
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число от 100 до 999: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = duo(N);

int duo(int N)
{
    int uno = N / 100;
    int tres = N % 10;
    return (N / 10) % 10;

}
int total = duo(N);
Console.WriteLine("Второй цифрой введенного числа является: ");
Console.WriteLine(total);


Console.WriteLine("Проверить чётность найденной второй цифры? (Ведите Да или Нет)");
string answer = Console.ReadLine();

if (answer.ToLower() == "да")
{
if (total % 2 == 1)
{
    Console.WriteLine("Число нечетное и делится на два с остатком");
}
else
{
    Console.WriteLine("Число четное и делится на два без остатка");
}
}
else
{
    Console.WriteLine("Спасибо, что применили ИИ кулькулятор! Успехов Вам!");
}