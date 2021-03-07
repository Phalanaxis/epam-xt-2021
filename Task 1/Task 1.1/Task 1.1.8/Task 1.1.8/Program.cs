using System;

namespace Task_1._1._8
{
    class Program
    {
        static void No_positive()
        {
            int[,,] array = new int[5, 5, 5];
            Random r = new Random();
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        array[a,b,c] = r.Next(-10, 10);

                        if (array[a,b,c] > 0)
                        {
                            array[a, b, c] = 0;  
                        }

                        Console.WriteLine($"{array[a,b,c]}    ");
                    }
                }
            }

        }
        static void Main()
        {
            No_positive();
        }
    }
}
