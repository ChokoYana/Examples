//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int ProductNumber (int num1, int num2)
{
    int prod = 1;
    for(int current = 1; current <= num2; current++)
        prod = prod * num1;
    return prod;
}

Console.WriteLine("Input number1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ProductNumber(a, b));
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void FindSum (int num)
{
    int sum = 0;
    while(num !=0)
    {
        sum = sum + num % 10;
        num = num /10;
    }
    Console.WriteLine($"Sum = {sum}");
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindSum(number);
*/

// Напишите программу, которая запрашивает у пользователя размер массива и показывает его..

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Ведите {i + 1} элемент массива:");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}


void ShowArray( int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(sizeArray));