using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hwTest
{
    internal class Program
    {

        // Function to perform spiral order traversal of a matrix
        public static List<int> SpiralOrder(ref int[,] matrix)
        {
            // Number of rows in the matrix
            int m = matrix.GetLength(0);

            // Number of columns in the matrix
            int n = matrix.GetLength(1);

            // List to store the spiral order elements
            List<int> result = new List<int>();

            // Edge case: if matrix is empty
            if (m == 0)
                return result;

            // 2D array to keep track of visited cells
            bool[,] seen = new bool[m, n];

            // Arrays to represent the four possible movement
            // directions: right, down, left, up

            // Change in row index for each direction
            int[] dr = { 0, 1, 0, -1 };

            // Change in column index for each direction
            int[] dc = { 1, 0, -1, 0 };

            // Initial position in the matrix
            int r = 0, c = 0;

            // Initial direction index (0 corresponds to 'right')
            int di = 0;

            // Iterate through all elements in the matrix
            for (int i = 0; i < m * n; ++i)
            {
                // Add current element to result list
                result.Add(matrix[r, c]);

                // Mark current cell as visited
                seen[r, c] = true;

                // Calculate the next cell coordinates based on
                // current direction
                int newR = r + dr[di];
                int newC = c + dc[di];

                // Check if the next cell is within bounds and not
                // visited
                if (0 <= newR && newR < m && 0 <= newC && newC < n
                    && !seen[newR, newC])
                {
                    // Move to the next row
                    r = newR;

                    // Move to the next column
                    c = newC;
                }
                else
                {
                    // Change direction (turn clockwise)
                    di = (di + 1) % 4;

                    // Move to the next row according to new
                    // direction
                    r += dr[di];

                    // Move to the next column according to new
                    // direction
                    c += dc[di];
                }
            }

            // Return the list containing spiral order elements
            return result;
        }
        public static void PrintMatrix(ref int [,]matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Main function
        public static void Main()
        {
            // Example matrix initialization

            int[,] matrix = {
            { 1,  2,  3,  4 },
            { 5,  6,  7,  8 },
            { 9,  10, 11, 12},
            { 13, 14, 15, 16}
        };
            
            PrintMatrix(ref matrix);

            // Function call to get the spiral order traversal
            List<int> result = SpiralOrder(ref matrix);

            // Print the result elements
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

        }
    }
}
