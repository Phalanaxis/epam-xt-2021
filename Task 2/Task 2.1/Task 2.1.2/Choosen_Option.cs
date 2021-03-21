using System;
using System.Collections.Generic;
using System.Text;
using Task_2._1._2;

namespace Task_2._1._2
{
    class Choosen_Option
    {
        static List<Figure> List_of_figures = new List<Figure>();
        static int Input(string Initial)
        {
            int.TryParse(Console.ReadLine(), out int number);
            return number;
        }

        public static void Choice_Line()
        {
            Console.WriteLine("Введите параметры фигуры Линия:  ");
            Console.WriteLine("Введите координаты первой точки:    ");
            int x_1 = Input("x1 = ");
            int y_1 = Input("y1 = ");
            Console.WriteLine("Введите координаты второй точки:     ");
            int x_2 = Input("x2 = ");
            int y_2 = Input("y2 = ");
            Console.WriteLine("Введите название фигуры:     ");
            string name = Console.ReadLine();
            List_of_figures.Add(new Line(x_1, y_1, x_2, y_2, name));
        }

        public static void Choice_Triangle()
        {
            Console.WriteLine("Введите параметры фигуры Треугольник:    ");
            Console.WriteLine("Введите координаты первой точки:     ");
            int x_1 = Input("x1 = ");
            int y_1 = Input("y1 = ");
            Console.WriteLine("Введите координаты второй точки:     ");
            int x_2 = Input("x2 = ");
            int y_2 = Input("y2 = ");
            Console.WriteLine("Введите координаты третьей точки:    ");
            int x_3 = Input("x3 = ");
            int y_3 = Input("y3 = ");
            Console.WriteLine("Введите название фигуры:     ");
            string name = Console.ReadLine();
            List_of_figures.Add(new Triangle(x_1, y_1, x_2, y_2, x_3, y_3, name));
        }

        public static void Choice_Square()
        {
            Console.WriteLine("Введите параметры фигуры Квадрат:    ");
            Console.WriteLine("Введите координаты первой точки:     ");
            int x_1 = Input("x1 = ");
            int y_1 = Input("y1 = ");
            Console.WriteLine("Введите координаты второй точки:     ");
            int x_2 = Input("x2 = ");
            int y_2 = Input("y2 = ");
            Console.WriteLine("Введите название фигуры:     ");
            string name = Console.ReadLine();
            List_of_figures.Add(new Square(x_1, y_1, x_2, y_2, name));
        }

        public static void Choice_Rectangle()
        {
            Console.WriteLine("Введите параметры фигуры Прямоугольник:  ");
            Console.WriteLine("Введите координаты первой точки стороны A:     ");
            int x_1 = Input("x1 = ");
            int y_1 = Input("y1 = ");
            Console.WriteLine("Введите координаты второй точки стороны A:     ");
            int x_2 = Input("x2 = ");
            int y_2 = Input("y2 = ");
            Console.WriteLine("Введите высоту фигуры Прямоугольника:     ");
            int h = Input("h = ");
            Console.WriteLine("Введите название фигуры:     ");
            string name = Console.ReadLine();
            List_of_figures.Add(new Rectangle(x_1, y_1, x_2, y_2, h, name));
        }

        public static void Choice_Circle()
        {
            Console.WriteLine("Введите параметры фигуры окружность:      ");
            Console.WriteLine("Введите координаты центра:          ");
            int x = Input("x = ");
            int y = Input("y = ");
            Console.WriteLine("Введите радиус:    ");
            int radius = Input("radius = ");
            Console.WriteLine("Введите название фигуры: ");
            string name = Console.ReadLine();
            List_of_figures.Add(new Circle(x, y, radius, name));
        }

        public static void Choice_Disk()
        {
            Console.WriteLine("Введите параметры фигуры Круг:      ");
            Console.WriteLine("Введите координаты центра:          ");
            int x = Input("x = ");
            int y = Input("y = ");
            Console.WriteLine("Введите радиус:    ");
            int radius = Input("radius = ");
            Console.WriteLine("Введите название фигуры: ");
            string name = Console.ReadLine();
            List_of_figures.Add(new Disk(x, y, radius, name));
        }

        public static void Choice_Ring()
        {
            Console.WriteLine("Введите параметры фигуры Кольцо:    ");
            Console.WriteLine("Введите координаты центра:          ");
            int x = Input("x = ");
            int y = Input("y = ");
            Console.WriteLine("Введите внешний радиус:   ");
            int outer_radius = Input("radius = ");
            Console.WriteLine("Введите ввнутренний радиус:   ");
            int inner_Radius = Input("inner radius = ");
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            List_of_figures.Add(new Ring(x, y, outer_radius, inner_Radius, name));
        }

        public static void Output()
        {
            for (int i = 0; i < List_of_figures.Count; i++)
            {
                if (List_of_figures[i] is Line)
                {
                    Line line = List_of_figures[i] as Line;
                    Console.WriteLine($"Фигура Линия: {line.Name}");
                    Console.WriteLine($"Длина линии: {line.LengthLine()}");
                }

                if (List_of_figures[i] is Square)
                {
                    Square square = List_of_figures[i] as Square;
                    Console.WriteLine($"Фигура Квадрат: {square.Name}");
                    Console.WriteLine($"Площадь квадрата: {square.S()}");
                    Console.WriteLine($"Периметр квадрата: {square.P()}");
                }

                if (List_of_figures[i] is Rectangle)
                {
                    Rectangle rectangle = List_of_figures[i] as Rectangle;
                    Console.WriteLine($"Фигура Прямоугольник: {rectangle.Name}");
                    Console.WriteLine($"Площадь прямоугольника: {rectangle.S()}");
                    Console.WriteLine($"Периметр прямоугольника: {rectangle.P()}");
                    Console.WriteLine();
                }

                if (List_of_figures[i] is Triangle)
                {
                    Triangle triangle = List_of_figures[i] as Triangle;
                    Console.WriteLine($"Фигура Треугольник: {triangle.Name}");
                    Console.WriteLine($"Периметр треугольника: {triangle.P()}");
                    Console.WriteLine($"Площадь треугольника: {triangle.S()}");
                }

                if (List_of_figures[i] is Circle)
                {
                    Disk circle = List_of_figures[i] as Disk;
                    Console.WriteLine($"Фигура Круг: {circle.Name}");
                    Console.WriteLine($"Длина описанной окружности: {circle.Circumference()}");
                    Console.WriteLine($"Площадь круга: {circle.S()}");
                    Console.WriteLine();
                }

                if (List_of_figures[i] is Disk)
                {
                    Disk disk = List_of_figures[i] as Disk;
                    Console.WriteLine($"Фигура Круг: {disk.Name}");
                    Console.WriteLine($"Длина описанной окружности: {disk.Circumference()}");
                    Console.WriteLine($"Площадь круга: {disk.S()}");
                    Console.WriteLine();
                }

                if (List_of_figures[i] is Ring)
                {
                    Ring ring = List_of_figures[i] as Ring;
                    Console.WriteLine($"Фигура Кольцо: {ring.Name}");
                    Console.WriteLine($"Суммарная длина внешней и внутренней окружностей: {ring.Circumference()}");
                    Console.WriteLine();
                }
            }
        }

        public static void Clear()
        {
            Console.Clear();
            List_of_figures.Clear();
        }
    }
}
 