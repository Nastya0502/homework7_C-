// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        Console.WriteLine();
    }
}

void PrintResult(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}; ");;
    }
    Console.Write($"{array[array.Length-1]}.");
}

double[] AverageCols(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    double sum = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum+=array[i,j];
        result[j] = Math.Round(sum/array.GetLength(0), 2);
        sum = 0.0;
    }
    // for (int i = 0; i < result.Length-1; i++)
    //     Console.Write($"{result[i]}; ");
    // Console.Write($"{result[result.Length-1]}");
    return result;
}




Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
PrintResult(AverageCols(array));
