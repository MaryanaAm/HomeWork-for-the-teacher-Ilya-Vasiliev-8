// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


internal class Program
{
    private static void Main(string[] args)
    {
        int GetNumber(string message)
        {
            int result = 0;

            while (true)
            {
                Console.WriteLine(message);

                if (int.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ввели не число");
                }
            }

            return result;
        }

        int[,] InitMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        int num = GetNumber("Введите количество строк:");
        int[,] matrix = InitMatrix(num, num);
        PrintMatrix(matrix);



        int min = 0;
        int row = 0;
        int sumRow = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            min += matrix[0, i];
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                sumRow += matrix[i, j];

            if (sumRow < min)
            {
                min = sumRow;
                row = i;
            }
            sumRow = 0;
        }
        Console.Write($"Строка с наименьшей суммой: {row + 1}");
    }
}