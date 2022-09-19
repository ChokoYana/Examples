// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if(n > m)
    {
        if(n > m) ShowNums(m, n - 1);
        Console.Write(n + " ");
    } 
    else 
    {
        if(m > n) ShowNums(m, n + 1);
        Console.Write(n + " ");
    }
}

Console.WriteLine("Input number 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n);
*/


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNums (int m, int n)
{
    if(m <= n) return SumNums(m + 1, n) + m;
    else return 0;
}

Console.WriteLine("Input number 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNums(m, n));
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanFunction (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0 && m > 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else if(m > 0 && n > 0)
    {
        return AckermanFunction (m - 1, AckermanFunction(m, n - 1));
    }
    else return 1;
}


Console.WriteLine(AckermanFunction(3,2));
*/