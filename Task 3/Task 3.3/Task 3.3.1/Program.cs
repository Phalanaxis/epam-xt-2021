using System;
using System.Linq;

namespace Task_3._3._1
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 6, 9, 8, 4, 2, 1, 4, 6, 3 };

            arr.Action(x => x - 1);
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.Get_Sum());
            Console.WriteLine();
            Console.WriteLine(arr.Get_Average());
            Console.WriteLine();
            Console.WriteLine(arr.Get_Most_Common());
        }
    }
}
