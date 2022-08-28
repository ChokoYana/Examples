// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 ->  нет    12821 -> да    23432 -> да

/*
void SearchPolindromNum (int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10) 
    {
        Console.WriteLine($"Yes");
    }
    else Console.WriteLine($"No");
}

Console.Write("imput number: ");
int num = Convert.ToInt32 (Console.ReadLine());
SearchPolindromNum(num);
*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

Console.WriteLine("Enter the first dot: ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second dot: ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance is {dist}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void KubNumber(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine(current * current * current);
        current ++;
    }
}

Console.Write("imput number: ");
int num = Convert.ToInt32 (Console.ReadLine());
KubNumber(num);
*/