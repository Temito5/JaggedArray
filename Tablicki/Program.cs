using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablicki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][][] sheet = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int rows = size[0];
                int cols = size[1];
                sheet[i] = new int[rows][];
                for (int row = 0; row < rows; row++)
                {
                    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    sheet[i][row] = values;
                }
            }
            double[] sheetAvg = new double[n];
            for (int i = 0; i < n; i++)
            {
                int min = sheet[i][0][0];
                int max = sheet[i][0][0];
                int summarise = 0;

                for (int rw = 0; rw < sheet[i].Length; rw++)
                {
                    for (int cl = 0; cl < sheet[i][rw].Length; cl++)
                    {
                        int value = sheet[i][rw][cl];

                        if (value < min)
                        {
                            min = value;
                        }

                        if (value > max)
                        {
                            max = value;
                        }

                        summarise += value;
                    }
                }
                double average = (double)summarise / (sheet[i].Length * sheet[i][0].Length);
                sheetAvg[i] = average;
                Console.WriteLine();
                Console.WriteLine($"{min} {max} {average:f2}");
            }
            double documentAvg = sheetAvg.Average();
            for (int i = 0; i < sheetAvg.Length; i++)
            {
                if (sheetAvg[i] > documentAvg)
                {
                    Console.Write("2 ");
                }
                else
                {
                    Console.Write("4 ");
                }
            }
            Console.WriteLine();
        }
    }
}
