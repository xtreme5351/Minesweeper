using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{

    internal class Solver
    {
        private string[,] grid;
        public int[,] freqMap;
        private int gridDimension;
        private int totalCells;

        public Solver(string[,] grid)
        {
            this.grid = grid;
            gridDimension = grid.GetLength(0);
            totalCells = (int)Math.Pow(gridDimension, 2);
            freqMap = new int[gridDimension, gridDimension];
            ConvertToFreqMap();
            PrintGrid(grid);
        }

        private void ConvertToFreqMap()
        {
            for (int n = 0; n < totalCells; n++)
            {   
                int y = n / gridDimension;
                int x = n % gridDimension;
                freqMap[x, y] = GetSelfValue(grid, x, y);
            }

        }

        public static int GetSelfValue(string[,] arr, int i, int j)
        {
            int n = arr.Length;
            int m = arr.GetLength(0);
            List<string> v = new List<string>();
            for (int y = -1; y < 2; y++)
            {
                for (int x = -1; x < 2; x++)
                {
                    try
                    {
                        v.Add(arr[(i + y), (j + x)]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                }
            }
            int count = v.Count(x => x == "M");
            return (arr[i, j] == "M") ? -1: count;
        }

        private static void PrintGrid(string[,] grid)    
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write("|" + grid[i, j]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

    }
}
