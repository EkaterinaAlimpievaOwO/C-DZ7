// ----------------------------------------------------------------------------------------------------->
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// float[,] matrix = CreateMatrix(m, n, -10, 10);
// PrintMatrix(matrix);


// ----------------------------------------------------------------------------------------------------->

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Random random = new Random();
// int m = random.Next(3, 5);
// int n = random.Next(2, 5);
// float[,] matrix = CreateMatrix(m, n, -10, 10);
// PrintMatrix(matrix);
// Console.WriteLine("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine()) - 1;
// Console.WriteLine("Введите номер столбца: ");
// int column = int.Parse(Console.ReadLine()) - 1;
// Console.WriteLine();
// FindElement(matrix, row, column);


// ----------------------------------------------------------------------------------------------------->

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Random random = new Random();
// int m = random.Next(3, 5);
// int n = random.Next(2, 5);
// int[,] matrix = CreateIntMatrix(m, n, 1, 10);
// PrintIntMatrix(matrix);
// FindAverage(matrix);

// ----------------------------------------------------------------------------------------------------->

float[,] CreateMatrix(int x, int y, int min, int max)
{
    var random = new Random();
    float[,] matrix = new float[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
        Console.WriteLine();
    }
    return matrix;
}


int[,] CreateIntMatrix(int x, int y, int min, int max)
{
    var random = new Random();
    int[,] matrix = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = random.Next(min, max);
        }
        Console.WriteLine();
    }
    return matrix;
}


void PrintMatrix(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|" + matrix[i, j] + "| ");
        }
        Console.WriteLine();
    }
}


void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|" + matrix[i, j] + "| ");
        }
        Console.WriteLine();
    }
}


void FindElement(float[,] array, int x, int y)
{
    if (x >= 0 && y >= 0 && x < array.GetLength(0) && y < array.GetLength(1))
    {
        Console.WriteLine(array[x, y]);
    }
    else
    {
        Console.WriteLine("Отсутствует элемент с такими индексами");
    }
}


void FindAverage(int[,] array)
{
    float [] result = new float [array.GetLength(1)];  
    for(int i = 0; i < array.GetLength(1); i++)
    {
        float average = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j,i];
        }
        result[i] = average / array.GetLength(0);
    }
    PrintArray(result);
}


void PrintArray(float[] array)
{
    Console.WriteLine("Среднее арифметическое элементов каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}