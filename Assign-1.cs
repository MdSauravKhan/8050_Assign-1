using System;

namespace Asignment_8050
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N :");
            int n = int.Parse(Console.ReadLine());

            //initiate the value of regions to 0!!!

            int region_1 = 0;
            int region_2 = 0;
            int region_3 = 0;
            int region_4 = 0;

            //Array to take input value for x,y according to N!!!
            int[] x = new int[n];
            int[] y = new int[n];
                        
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the value of x :");
                x[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the value of y :");
                y[i] = int.Parse(Console.ReadLine());
            }

            //loop for checking x and y value with equations!!!

            for (int i = 0; i < n; i++)
            {
                
                double equation_1 = Math.Pow(x[i] - 2, 2) + Math.Pow(y[i] - 2, 2);
                double equation_2 = x[i] + y[i];

                if (equation_1 <= 1 && equation_2 > 3)
                {
                    Console.WriteLine("({0},{1}) represent the region 1", x[i], y[i]);
                    region_1++;
                }
                if (equation_1 <= 1 && equation_2 <= 3)
                {
                    Console.WriteLine("({0},{1}) represent the region 2", x[i], y[i]);
                    region_2++;
                }
                if (equation_1 > 1 && equation_2 <= 3)
                {
                    Console.WriteLine("({0},{1}) represent the region 3", x[i], y[i]);
                    region_3++;
                }
                if (equation_1 > 1 && equation_2 > 3)
                {
                    Console.WriteLine("({0},{1}) represent the region 4", x[i], y[i]);
                    region_4++;
                }
            }

            Console.WriteLine("For Region 1 : {0},    Region 2 : {1},    Region 3 : {2},    Region 4 : {3}", region_1, region_2, region_3, region_4);
            Console.WriteLine("-------------------------------------------------------------");
                             
        }
    }
}

