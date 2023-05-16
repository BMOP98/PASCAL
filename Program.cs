using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de filas del triángulo de Pascal: ");
        int numRows = Convert.ToInt32(Console.ReadLine());

        int[][] triangle = new int[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }

            triangle[i][i] = 1;
        }

        Console.WriteLine("Triángulo de Pascal:\n");

        int maxDigits = triangle[numRows - 1][(numRows - 1) / 2].ToString().Length;

        for (int i = 0; i < numRows; i++)
        {
            int spaces = (numRows - i - 1) * (maxDigits + 1) / 2;

            for (int s = 0; s < spaces; s++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i][j].ToString().PadLeft(maxDigits, ' ') + " ");
            }
            Console.WriteLine();
        }
    }
}