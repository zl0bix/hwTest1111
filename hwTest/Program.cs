using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[4, 6];
          
            Random random = new Random();
            string str = "" ;
            Console.WriteLine(matrix1.GetLength(0));
            //matrix1.Rank;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i,j] = random.Next(1, 11);
                    Console.Write(matrix1[i, j]+"\t");
                    
                    if (j ==  matrix1.GetLength(1) -1 )
                    {
                        str += matrix1[i, j];
                    }                                        
                }
                Console.WriteLine();               
            }
            Console.WriteLine(str);
        }
    }
}
