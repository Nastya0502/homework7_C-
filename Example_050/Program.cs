// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-20,21);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            System.Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}


string FindElement(int[,] array, int num)
{
    string result = "Такого числа в массиве нет";
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
        {
            if (num==array[i,j])
                result = $"({i};{j})";
        }
        }
    return result;        
}


Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
Console.WriteLine();
Console.Write("Введите искомое число от -20 до 20: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
Console.WriteLine(FindElement(array, n));