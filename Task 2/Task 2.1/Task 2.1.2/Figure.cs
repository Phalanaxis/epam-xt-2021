using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    public class Figure
    {
        public int X_1 { get; set; }
        public int Y_1 { get; set; }

        public string Name { get; set; }

        public Figure(int x_1, int y_1, string name)
        {
            X_1 = x_1;
            Y_1 = y_1;
            Name = name;
        }
    }
}
