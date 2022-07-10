// // // // Console.Write("Введите первое число: ");
// // // // int squareNumber = Convert.ToInt32(Console.ReadLine());
// // // // Console.Write("Введите второе число: ");
// // // // int number = Convert.ToInt32(Console.ReadLine());
// // // // // True , False. "==" - проверка на равенство
// // // // if (squareNumber == number * number)
// // // // {
// // // //     Console.WriteLine("Число " + squareNumber + " является квадратом " + number);
// // // //     // "2" + "2" = "22" - процесс сложения двух строк - конкатенация
// // // // }
// // // //  // if (squareNumber != number * number)  != - неравенство
// // // // else
// // // // {
// // // //     Console.WriteLine("Число " + squareNumber + " НЕ является квадратом " + number);
// // // // }

// // // // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // // // 	3 -> Среда 
// // // // 5 -> Пятница

// // // int dayNumber = Convert.ToInt32(Console.ReadLine());
// // // if (dayNumber >= 1 && dayNumber <= 7) // (1,7) True && True -> True
// // // {
// // //     if (dayNumber == 1)
// // //         (
// // //           Console.WriteLine("Понедельник");  
// // // )
// // // if (dayNumber == 2)
// // //         (
// // //           Console.WriteLine("Вторник");  
// // // )
// // // if (dayNumber == 3)
// // //         (
// // //           Console.WriteLine("Среда");  
// // // )
// // // if (dayNumber == 4)
// // //         (
// // //           Console.WriteLine("Четверг");  
// // // )
// // // if (dayNumber == 5)
// // //         (
// // //           Console.WriteLine("Пятница");  
// // // )
// // // if (dayNumber == 6)
// // //         (
// // //           Console.WriteLine("Суббота");  
// // // )
// // // if (dayNumber == 7)
// // //         (
// // //           Console.WriteLine("Воскресенье");  
// // // )
// // // }
// // // else
// // // {
// // //     Console.WriteLine("Error 404, day not found");
// // // }

// // Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // 2 -> " -2, -1, 0, 1, 2"


 int N = Convert.ToInt32(Console.ReadLine());

 int negativeN = N *(-1);

 while (negativeN <= N)
 {
     System.Console.WriteLine(negativeN);
     negativeN ++;
 }