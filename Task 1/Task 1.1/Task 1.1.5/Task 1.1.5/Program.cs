using System;

namespace Task_1._1._5
{
    class Program
    {
        static void sum_of_numbers()
        {
            int sum = 0;

            for(int current_number = 0; current_number < 1000; current_number++)
            {
                if (current_number % 3 == 0 || current_number % 5 == 0)
                {
                    sum = sum + current_number;
                } 
            }
            Console.WriteLine(sum);
        }
        static void Main()
        {
            sum_of_numbers();
        }
    }
}
