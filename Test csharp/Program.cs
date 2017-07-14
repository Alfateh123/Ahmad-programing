using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_csharp
{
    class Program
    {
        static void isprime(int x)
        { int count = 0;
            for (int i = 1; i <= x; i++)
            {
                count = 0;
                for (int j = 2; j < i || j <= 2; j++)
                {
                    if (i % j == 0) count++;

                }
                if (count > 0) Console.WriteLine($"{i} is not prime ");
                else Console.WriteLine($"{i} is  prime ");

            }
        }
        static void Reverse (int x)
            {
            int r = 0, mod = 0, temp=x;
            do
            {
                mod = temp % 10;
                temp /= 10;
                r = r * 10 + mod;
            } while (temp > 0);

            Console.WriteLine($"{x} \n{r}");
            }
        static int[][] grid;
        static int []a = { 1, -1, 1, -1, 2, -2, 2, -2 };
        static int []b = { 2, 2, -2, -2, 1, 1, -1, -1 };
        static void Print_matrix(int [][]array)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    Console.Write($"{grid[i][j]} ");
            Console.Write("\n");  
        }
     
        static void Main(string[] args)
        {
            /// data 
          
        }
    }
}
