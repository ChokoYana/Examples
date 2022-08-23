// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondNumber (int num)
{
    int sot = num / 10;
    int dec = sot % 10;

    return dec;
}

int randNumber = new Random().Next(10,1000);
int secondNum = FindSecondNumber(randNumber);

Console.WriteLine($"The second number {randNumber} is {secondNum}");
*/
/*
int FindSecondNumber (int num)
{
    int sot = num / 10;
    int dec = sot % 10;

    return dec;
}

Console.Write("imput three-digit number: ");
int number = Convert.ToInt32 (Console.ReadLine());
int secondNum = FindSecondNumber(number);

Console.WriteLine($"The second number {number} is {secondNum}");
*/

// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
/*
void FindThirdNumber(int num)

{
    int num3 = num % 10;
    if(num3 < 10)
        Console.WriteLine($"The third number {num} of {num3}");
    else Console.WriteLine($"The third number {num} not found");
}

Console.Write("imput number: ");
int number = Convert.ToInt32 (Console.ReadLine());

FindThirdNumber(number);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

