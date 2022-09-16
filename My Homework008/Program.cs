// Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.

/*
int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
                if(array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }

        }
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(newArray);
BubbleSort(newArray); 
Show2dArray(newArray); */



// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}



void MinSumRows (int[,] array)
{
    int iRows = 0;
    int sumRows = 2147483647;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumMin = 0;
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumMin += array[i, j];
        }
        Console.WriteLine(sumMin);
        
        if(sumMin < sumRows) 
        {
            sumRows = sumMin;
            iRows = i;
        }
    }
    Console.WriteLine(iRows);
}



Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(newArray);
MinSumRows(newArray);
*/



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixCalculation (int[,] array1, int[,] array2)
{
    int[,] arrayCalc = new int[array1.GetLength(0), array1.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
        for(int j = 0; j < array1.GetLength(1); j++)
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                arrayCalc[i,j] += array1[i,k] * array2[k,j];
            }

    return arrayCalc;
}



Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array1 = CreateRandom2dArray(m, n, min, max);
Show2dArray(array1);
int[,] array2 = CreateRandom2dArray(m, n, min, max);
Show2dArray(array2);
int[,] array3 = MatrixCalculation(array1, array2);
Show2dArray(array3);
*/


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Create3dArray(int row, int column, int length, int startNum)
{
    int[,,] array = new int[row, column, length];
    int s = 0;
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            for(int k = 0; k < length; k++)
                {
                    array[i, j, k] = startNum + s;
                    s ++;
                }
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write(array[i, j, k]);
                    Console.Write($"({i}, {j}, {k}) ");
                }
            Console.WriteLine();
        }
        
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of lenght: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input start number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,,] array1 = Create3dArray(m, n, l, num);
Show3dArray(array1);
*/

// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] CreateRandom2dArray(int row, int column)
{
    int[,] array = new int[row, column];
    int s = 1;
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            for(i = 0; i > row; i--)
                for(j = 0; j > column; j--)
                    {
                        array[i, j] = 1 + s;
                        s++;
                    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(i = 0; i > 0; i--)
            {
                for(j = 0; j > array.GetLength(1); j--)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
            }     
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray(4, 4);
Show2dArray(newArray); */