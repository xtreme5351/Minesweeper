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
        private int[,] freqMap;
        private int gridDimension;

        public Solver(string[,] grid)
        {
            this.grid = grid;
            gridDimension = grid.GetLength(0);
            freqMap = new int[gridDimension, gridDimension];
            ConvertToFreqMap();
            PrintGrid(freqMap);
        }

        private void ConvertToFreqMap()
        {
            for (int y = 0; y < grid.GetLength(0); y++)
            {   
               for (int x = 0; x < grid.GetLength(0); x++)
               {
                    freqMap[x, y] = GetSelfValue(grid, x, y);
               }
            }

        }

        public string GetMineValue(int i)
        {
            int x_1 = i / gridDimension;
            int y_1 = i % gridDimension;
            return freqMap[x_1, y_1].ToString();
        }

        public static int GetSelfValue(string[,] arr, int i, int j)
        {
            int n = arr.Length;
            int m = arr.GetLength(0);
            List<string> v = new List<string>();
            for (int x = -1; x < 6; x++)
            {
                try
                {
                    v.Add(arr[i + x / 3, j + x % 3]);
                } catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }
            int count = v.Count(x => x == "True");
            return (arr[i, j] == "True") ? count += 1: count;
        }

        private static void PrintGrid(int[,] grid)    
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write("|" + grid[i, j].ToString());
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

    }
}
