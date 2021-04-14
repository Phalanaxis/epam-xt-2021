using System;
using System.Linq;

namespace Task_3._3._1
{
    public static class Super_Array
    {
        public static void Action(this int[] array, Func<int, int> function)
        {
            if (function != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = function.Invoke(array[i]);
                }
            }
        }

        public static int Get_Sum(this int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        public static int Get_Average(this int[] array)
        {
            int average = Get_Sum(array)/ array.Length;
            return average;
        }

        public static int Get_Most_Common(this int[] array)
        {
            return array.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().Key;
        }
    }
}
