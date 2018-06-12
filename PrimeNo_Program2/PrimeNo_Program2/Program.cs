using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo_Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0;
                Console.Write("Enter the number ");
                n = int.Parse(Console.ReadLine());
                primeNo(n);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
        public static void primeNo(int n)
        {
            bool flag = true;
            int sum = 0;
            for (int i = 2; i < n; i++) // i<n to check Number to be printed is less than ‘N’
            {

                for (int j = 2; j < i; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {

                    sum += i;    // to check Addition of numbers printed are less than number ‘n’               
                    if (sum < n)
                    {
                        Console.Write(i + " ");
                    }

                }

                flag = true;
            }
        }
    }
}
