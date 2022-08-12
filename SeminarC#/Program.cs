// // // // // // // Console.Write("Введите первое число: ");
// // // // // // // int squareNumber = Convert.ToInt32(Console.ReadLine());
// // // // // // // Console.Write("Введите второе число: ");
// // // // // // // int number = Convert.ToInt32(Console.ReadLine());
// // // // // // // // True , False. "==" - проверка на равенство
// // // // // // // if (squareNumber == number * number)
// // // // // // // {
// // // // // // //     Console.WriteLine("Число " + squareNumber + " является квадратом " + number);
// // // // // // //     // "2" + "2" = "22" - процесс сложения двух строк - конкатенация
// // // // // // // }
// // // // // // //  // if (squareNumber != number * number)  != - неравенство
// // // // // // // else
// // // // // // // {
// // // // // // //     Console.WriteLine("Число " + squareNumber + " НЕ является квадратом " + number);
// // // // // // // }

// // // // // // // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // // // // // // 	3 -> Среда 
// // // // // // // 5 -> Пятница

// // // // // // int dayNumber = Convert.ToInt32(Console.ReadLine());
// // // // // // if (dayNumber >= 1 && dayNumber <= 7) // (1,7) True && True -> True
// // // // // // {
// // // // // //     if (dayNumber == 1)
// // // // // //         (
// // // // // //           Console.WriteLine("Понедельник");  
// // // // // // )
// // // // // // if (dayNumber == 2)
// // // // // //         (
// // // // // //           Console.WriteLine("Вторник");  
// // // // // // )
// // // // // // if (dayNumber == 3)
// // // // // //         (
// // // // // //           Console.WriteLine("Среда");  
// // // // // // )
// // // // // // if (dayNumber == 4)
// // // // // //         (
// // // // // //           Console.WriteLine("Четверг");  
// // // // // // )
// // // // // // if (dayNumber == 5)
// // // // // //         (
// // // // // //           Console.WriteLine("Пятница");  
// // // // // // )
// // // // // // if (dayNumber == 6)
// // // // // //         (
// // // // // //           Console.WriteLine("Суббота");  
// // // // // // )
// // // // // // if (dayNumber == 7)
// // // // // //         (
// // // // // //           Console.WriteLine("Воскресенье");  
// // // // // // )
// // // // // // }
// // // // // // else
// // // // // // {
// // // // // //     Console.WriteLine("Error 404, day not found");
// // // // // // }

// // // // // Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// // // // // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // // // // 2 -> " -2, -1, 0, 1, 2"


// // // //  int N = Convert.ToInt32(Console.ReadLine());

// // // //  int negativeN = N *(-1);

// // // //  while (negativeN <= N)
// // // //  {
// // // //      System.Console.WriteLine(negativeN);
// // // //      negativeN ++;
// // // //  }


// // // // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// // // Console.Write("Введите координату Х:");

// // // int x = Int32.Parse(Console.ReadLine());

// // // Console.Write("Введите координату Y:");

// // // int y = Convert.ToInt32(Console.ReadLine());

// // // if (x > 0 && y > 0)
// // // {
// // //     Console.WriteLine("Четверть: 1");
// // // }
// // // else if (x < 0 && y > 0)
// // // {
// // //     Console.WriteLine("Четверть: 2");
// // // }

// // // else if (x < 0 && y < 0)
// // // {
// // //     Console.WriteLine("Четверть: 3");
// // // }

// // // else if (x > 0 && y < 0)
// // // {
// // //     Console.WriteLine("Четверть: 4");
// // // }

// // // Задача 18: Напишите программу, которая по заданному номеру четверти, 
// // // показывает диапазон возможных координат точек в этой четверти (x и y).







// // // Задача 21: Напишите программу, которая принимает на вход координаты двух
// // // точек и находит расстояние между ними в 2D пространстве.
// // // A (3,6); B (2,1) -> 5,09 
// // // A (7,-5); B (1,-1) -> 7,21






// // // Задача 22: Напишите программу, которая принимает на вход число (N) и 
// // // выдаёт таблицу квадратов чисел от 1 до N.
// // // 5 -> 1, 4, 9, 16, 25.
// // // 2 -> 1,4


// // int x1 = Convert.ToInt32(Console.ReadLine());
// // int x2 = Convert.ToInt32(Console.ReadLine());
// // int y1 = Convert.ToInt32(Console.ReadLine());
// // int y2 = Convert.ToInt32(Console.ReadLine());

// // // Формула: d = √ (x 2 - x 1)^2+ (y 2 - y 1)^2

// // var result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)); 
// // // var определит тип переменной, которая будет в ответе

// // Console.WriteLine(Math.Round(result));
// // // int quarter = Convert.ToInt32(Console.ReadLine());

// // // if (quarter == 1) Console.WriteLine("x > 0 and y > 0");
// // // else if (quarter == 2) Console.WriteLine("x < 0 and y > 0");
// // // else if (quarter == 3) Console.WriteLine("x < 0 and y < 0");
// // // else if (quarter == 4) Console.WriteLine("x  0 and y < 0");
// // // else System.Console.WriteLine("error 404, quarter not found");

// // 30
// // Двоичные числа: 1 и 0

// // int[] array = GetBinaryArray(8);
// // Console.Write($"[{String.Join(",", array)}]");
// // int[] GetBinaryArray(int size)
// // {
// //     int[] result = new int[size];
// //     // new int[size] - массив размером size элементов
// //     // заполнен массив "0"
// //     // result.Length = size
// //     for (int i = 0; i < result.Length; i++)
// //     {
// //         result[i] = new Random().Next(2);// [0;2)
// //         // (2) - считаем, что числа от 0 до 1 (2 не включается)
// //     }
// //     return result; // int [] result
// // }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()); // строки
// // матрица - двумерный массив
// // матрица - табличка, которая состоит из m строк и n столбцов
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()); // столбцы

// /// summary - "///" - комментарий перед методом
// /// Описывает входные и выходные данные метода

// // Комментарий, а summary - только для методов

// /// m - кол-во строк, n - кол-во столбцов
// /// minRandom, maxRandom
// int[,] GetArray(int m, int n, int minRandom, int maxRandom)
// {
// //new int[кол-во строк,кол-во столбцов]
// int[,] matrix = new int[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++) // строчки: GetLength(1) = m (кол-во строк)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
// {
// matrix[i, j] = new Random().Next(minRandom, maxRandom + 1); //[)
// }
// }
// return matrix;
// }

// int[,] resultMatrix = GetArray(rows, columns, 0, 10);
// PrintArray(resultMatrix);
// void PrintArray(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++) // строчки
// {
// for (int j = 0; j < matrix.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
// {
// Console.Write(matrix[i, j] + "\t"); // "\t" - Tab между элементами
// }
// Console.WriteLine();
// }

