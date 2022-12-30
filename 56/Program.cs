
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длину массива: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int[,] array = new int[num, num];
        int[] temp = new int[num];

        Random ran = new Random();
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                array[i, j] = ran.Next(1, 15);
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Сортировка по строкам: ");
        Console.WriteLine();

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                temp[j] = array[i, j];
                Array.Sort(temp);
                Array.Reverse(temp);
            }
            for (int k = 0; k < num; k++)
            {
                array[i, k] = temp[k];
                Console.Write("{0}\t", array[i, k]);
            }
            Console.WriteLine();
        }
    }
}