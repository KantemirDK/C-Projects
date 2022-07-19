Console.WriteLine("Введите пятизначное число для проверки: ");
uint a = uint.Parse(Console.ReadLine());
uint b = a;
var col = new List<uint>();
while (b > 0)
{
    col.Add(b % 10);
    b = b / 10;
}
b = 0;
col.Reverse();
for (int mcol = 0; mcol < col.Count; mcol++)
    b = b + col[mcol] * (uint)Math.Pow(10, mcol);
if (a == b)
    Console.WriteLine("Введённое значение является палиндромом");
else
    Console.WriteLine("Введённое значение не являтется палиндромом");
