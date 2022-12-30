
// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

internal class Program
{
    private static void Main(string[] args)
    {
        int size = 4;
        int[,] mtrx = new int[size, size];
        int s = 1;


        for (int i = 0; i < size; i++)
        {
            mtrx[0, i] = s;
            s++;
        }

        for (int j = 1; j < size; j++)
        {
            mtrx[j, size - 1] = s;
            s++;
        }

        for (int i = size - 2; i >= 0; i--)
        {
            mtrx[size - 1, i] = s;
            s++;
        }

        for (int j = size - 2; j > 0; j--)
        {
            mtrx[j, 0] = s;
            s++;
        }


        int c = 1;
        int d = 1;

        while (s < size * size)
        {
            while (mtrx[c, d + 1] == 0) // в право
            {
                mtrx[c, d] = s;
                s++;
                d++;
            }

            while (mtrx[c + 1, d] == 0) // вниз
            {
                mtrx[c, d] = s;
                s++;
                c++;
            }

            while (mtrx[c, d - 1] == 0) // в лево
            {
                mtrx[c, d] = s;
                s++;
                d--;
            }

            while (mtrx[c - 1, d] == 0) // вверх
            {
                mtrx[c, d] = s;
                s++;
                c--;
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (mtrx[i, j] == 0)
                {
                    mtrx[i, j] = s;
                }
            }
        }


        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (mtrx[i, j] < size)
                {
                    Console.Write(mtrx[i, j] + "  \t");
                }
                else
                {
                    Console.Write(mtrx[i, j] + "  \t");
                }
            }
            Console.WriteLine();
        }
    }
}