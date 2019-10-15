using System;

namespace ExampleMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            double[,] mat = new double[x, x];

            for (int i = 0; i < x; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < x; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Main diagonal: ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: "+count);
        }
    }
}
