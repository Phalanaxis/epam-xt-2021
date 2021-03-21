using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Triangle : Figure
    {
        public int X_2 { get; set; }
        public int Y_2 { get; set; }
        public int X_3 { get; set; }
        public int Y_3 { get; set; }

        public Triangle(int x_1, int y_1, int x_2, int y_2, int x_3, int y_3, string name) : base(x_1, y_1, name)
        {
            X_2 = x_2;
            Y_2 = y_2;
            X_3 = x_3;
            Y_3 = y_3;
        }

        public double Side_A() => Math.Sqrt((X_2 - X_1) * (X_2 - X_1) + (Y_2 - Y_1) * (Y_2 - Y_1));

        public double Side_B() => Math.Sqrt((X_3 - X_2) * (X_3 - X_2) + (Y_3 - Y_2) * (Y_3 - Y_2));

        public double Side_C() => Math.Sqrt((X_3 - X_1) * (X_3 - X_1) + (Y_3 - Y_1) * (Y_3 - Y_1));

        public double P() => Side_A() + Side_B() + Side_C();
        public double S() => Math.Sqrt(P() * (P() - Side_A()) * (P() - Side_B()) * (P() - Side_C()));
    }
}
