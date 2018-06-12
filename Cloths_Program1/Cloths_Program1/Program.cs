using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloths_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int r, n;

                Console.Write("Enter the length of rope(R) ");
                r = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of cloths(N) ");
                n = int.Parse(Console.ReadLine());

                int[] size = new int[n];
                int[] start_points = new int[n];

                Console.Write("Enter the sizes of each cloths(1-{0}) ", r);
                for (int i = 0; i < n; i++)
                {
                    size[i] = int.Parse(Console.ReadLine());
                    if (size[i] <= 1 || size[i] > r + 1)
                    {
                        throw new Exception("Size of the cloth cannot be 0 or greater than lenght of rope");
                    }

                }

                Console.Write("Enter the start_ponts of each cloths (0-{0}) ", r - 1);
                for (int i = 0; i < n; i++)
                {
                    start_points[i] = int.Parse(Console.ReadLine());
                    if (start_points[i] < 0 || start_points[i] > r)
                    {
                        throw new Exception("Start point cannot be less than 0 or greater than lenght of rope");
                    }
                }

                int[] rope = new int[r];
                //Add some default value say -1(for empty space)
                for (int i = 0; i < r; i++)
                {
                    rope[i] = -1;
                }

                int fill = 0;


                for (int i = 0; i < n; i++)
                {
                    int loop1 = size[i];

                    int point = start_points[i];
                    while (loop1 > 0)
                    {
                        rope[point] = fill;
                        point++;
                        loop1--;


                    }
                    fill++;

                }


                //for (int i = 0; i < r; i++)
                //{
                //    Console.Write(rope[i]);
                //}

                int numberOfElements = rope.Distinct().Count();

                //Check for -1
                Boolean flag = false;
                foreach (int x in rope)
                {
                    if (x == -1)
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    numberOfElements--;
                }

                Console.WriteLine("number of clothes who are either completely or partially under direct sunlight");
                Console.Write(numberOfElements);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("Clothes cannot spread beyound the lenght of rope", e);

            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            Console.Read();
        }
    }
}
