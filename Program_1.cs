/* C#, lesson_40  15.04.2023																																					
																																					
Task № 1:																																					
Створити неузагальнений клас точки у тривимірному просторі з цілими координатами (Point3D), 																																					
який успадковується від generic-класу Point2D<T>.																																					
Реалізувати у класі:																																					
- конструктор з параметрами, який приймає початкові значення для координат точки																																					
- метод ToString()																																					
*/
//--------------------------------------------------------------------------------------------------------																																					
/*using System;
using System.Globalization;
using static System.Console;
namespace Lesson_40
{
    public class Point2D<T>             // базовий клас точки 2D
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y) { X = x; Y = y; }
        public Point2D() { X = default(T); Y = default(T); }

        public override string ToString()
        {
            return $"x = {X}  y = {Y}";
        }
    }

    public class Point3D : Point2D<int>             // клас точки 3D (int)
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public Point3D() : base()
        {
            Z = default(int);
        }

        public override string ToString()
        {
            return base.ToString() + $"  z = {Z}";
        }
    }

    public class Point3Dd : Point2D<double>             // клас точки 3D (double)
    {
        public double Z { get; set; }
        public Point3Dd(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }
        public Point3Dd() : base()
        {
            Z = default(double);
        }

        public override string ToString()
        {
            return base.ToString() + $"  z = {Z}";
        }
    }

    //--------------------------------------------------------------------------------------------------------																																					
    class Program_1
    {
        static void Main(string[] args)
        {
            Point2D<int> p1 = new Point2D<int>();
            WriteLine($"x = {p1.X} y = {p1.Y}");
            WriteLine("p1 = " + typeof(Point2D<int>));
            //WriteLine(p1.ToString());																																					

            Point2D<double> p2 = new Point2D<double>(10.5, 20.5);
            WriteLine("\n" + p2.ToString());
            WriteLine("p2 = " + typeof(Point2D<double>));

            Point3D p3 = new Point3D();
            WriteLine($"\nx = {p3.X} y = {p3.Y} z = {p3.Z}");
            WriteLine("p3 = " + typeof(Point3D));

            Point3D p4 = new Point3D(15, 18, 21);
            WriteLine("\n" + p4.ToString());
            WriteLine("p4 = " + p4.GetType());

            Point3Dd p5 = new Point3Dd();
            WriteLine("\n" + p5.ToString());
            WriteLine("p5 = " + p5.GetType());

            Point3Dd p6 = new Point3Dd();
            p6.X = 1.1;
            p6.Y = 2.2;
            p6.Z = 3.3;
            WriteLine("\n" + p6.ToString());
            WriteLine("p6 = " + p6.GetType());
        }
    }
}*/
