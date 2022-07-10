int[] array = { 16, 22, 36, 1143, 58, 346, 77, 148, 739, 1143 };

int n = array.Length;
int find = 1143;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine (index);
        break;
    }
    // index = index + 1;
    index++;
}