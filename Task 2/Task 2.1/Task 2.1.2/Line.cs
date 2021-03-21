using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    public class Line : Figure
    {
        public int X_2 { get; set; }
        public int Y_2 { get; set; }
        public Line(int x_1, int y_1, int x_2, int y_2, string name) : base(x_1, y_1, name)
        {
            X_2 = x_2;
            Y_2 = y_2; ;
        }

        public double LengthLine() => Math.Sqrt((X_2 - X_1) * (X_2 - X_1) + (Y_2 - Y_1) * (Y_2 - Y_1));
    }
}
