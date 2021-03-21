using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1._2
{
    class Ring : Figure
    {
        public int RADIUS { get; set; }
        public int INNER_RADIUS { get; set; }

        public Ring(int x_1, int y_1, int radius, int inner_radius, string name) : base(x_1, y_1, name)
        {
            RADIUS = radius;
            INNER_RADIUS = inner_radius;
        }

        public double Circumference() => 2 * Math.PI * (RADIUS * RADIUS - INNER_RADIUS * INNER_RADIUS);
    }
}
