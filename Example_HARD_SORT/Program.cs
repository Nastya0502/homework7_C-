// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}



int[,] SortArray(int[,] array)
{
    int[] array1 = new int[array.GetLength(0) * array.GetLength(1)];
    int z = 0;
    int[,] arraySort = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array1[z] = array[i, j];
            z++;
        }
    for (int i = 0; i < array1.Length; i++)
    {
        for (int j = 0; j < array1.Length - 1 - i; j++)
        {
            if (array1[j] > array1[j + 1])
            {
                (array1[j], array1[j + 1]) = (array1[j + 1], array1[j]);
            }
        }
    }
    z = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySort[i, j] = array1[z];
            z++;
        }
    return arraySort;
}








Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));