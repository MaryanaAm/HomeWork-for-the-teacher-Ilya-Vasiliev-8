// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] array1 = new int[4, 4];

        int[,] array2 = new int[4, 4];

        Random rnd = new Random();

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array1[i, j] = rnd.Next(1, 10);
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = rnd.Next(1, 10);
                Console.Write(array2[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Произведение двух матриц: \t");
        Console.WriteLine();

        int[,] arrayNew = new int[4, 4];

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                arrayNew[i, j] = array1[i, j] * array2[i, j];
                Console.Write("{0}\t", arrayNew[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}