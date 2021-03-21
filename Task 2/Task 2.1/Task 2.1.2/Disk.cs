using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Disk : Figure
    {
        public int RADIUS { get; set; }

        public Disk(int x_1, int y_1, int radius, string name) : base(x_1, y_1, name)
        {
            RADIUS = radius;
        }

        public double Circumference() => 2 * Math.PI * RADIUS;

        public double S() => Math.PI * RADIUS * RADIUS;
    }
}
