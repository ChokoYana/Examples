// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Imput number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if(number1>number2)
{
    Console.WriteLine($"Maximum number is {number1} and minimum number is {number2}");
}
else
{
    Console.WriteLine($"Maximum number is {number2} and minimum number is {number1}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Imput number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int Maximum = number1;
 
 if(Maximum>number2)
 {
    Console.WriteLine($"Maximum number is {number1}");
 }
else
{
    Maximum = number2;
}
if(Maximum>number3)
{
    Console.WriteLine($"Maximum number is {number2}");
}
else
{
    Maximum = number3;
}
Console.WriteLine($"Maximum number is {Maximum}");
*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без

/*
Console.Write("Imput number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 ==0)
{
    Console.WriteLine($"{number} is an even number!");
}
else
{
    Console.WriteLine($"{number} is not an even number!");
}
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Imput number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current<=number)
{
    Console.WriteLine(current);
    current = current + 2;
}
*/

/*
Console.Write("Imput number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if(number % 2 == 0) 
    {
        Console.WriteLine(current);
        current ++;
    }
    else 
    {
        current ++;
    }
}
*/
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 0;

while(current <= number)
{
    if(number % 2 == 0)
    {
        Console.WriteLine($"{current} четное");
        current++;

    }
    else
    {
        Console.WriteLine($"{current} нечетное");
        current++;
    }
}
*/