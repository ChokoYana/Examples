// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void ConsoleWrite(int num)
// {
//     int count = 0;
//     int current = 0;
//     while(current < num)
//     {
//         Console.WriteLine($"Input number {current + 1}: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if(n > 0) 
//         {
//             count++;
//         }
//         current++;
//     }
//     Console.WriteLine($"Number of > 0: {count}");
// }

// Console.Write("input number of numbers: ");
// int M = Convert.ToInt32(Console.ReadLine());
// ConsoleWrite(M);




// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double a1, double c1, double a2, double c2)
{
    double x = (a2 - a1) / (c1 - c2);
    double y = c1 * (a2 - a1) / (c1 - c2) + a1;
    Console.WriteLine($"точки пересечения ({x}, {y})");
}


Console.Write("input coordinate b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input coordinate k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input coordinate b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input coordinate k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);



// Console.Write("input coordinate b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input coordinate k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input coordinate b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input coordinate k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * (b2 - b1) / (k1 - k2) + b1;

// Console.WriteLine($"точки пересечения ({x}, {y})");
