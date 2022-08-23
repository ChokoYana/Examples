// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec;
    
    return max;

}

int randNumber = new Random().Next(10,100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}"); */

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.




//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если второе число не кратно числу 
//первому, то программа выводит остаток от деления.

/*
void Multiplicity (int a, int b)

{
    if(b % a == 0)
        Console.WriteLine($"Yes");
    else Console.WriteLine($"No");
}

Console.Write("imput first number: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("imput second number: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

Multiplicity(number1, number2);

*/