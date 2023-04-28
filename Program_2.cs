/* C#, lesson_40  15.04.2023																																					
																																					
Task № 2:																																					
Створити узагальнений клас прямої на площині.																																					
У класі передбачити 2 поля типу узагальненої точки — точки, через які проходить пряма. 																																					
Реалізувати в класі: 																																					
¦ конструктор, який приймає 2 точки 																																					
¦ конструктор, які приймає 4 координати (x і у координати для першої та другої точки) 																																					
¦ метод ToString()																																					
*/
//--------------------------------------------------------------------------------------------------------																																					
using System;
using System.Globalization;
using static System.Console;
namespace Lesson_40
{
    public class Point2D<T>                 // клас точки																																					
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y) { X = x; Y = y; }
        public Point2D() { X = default(T); Y = default(T); }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}";
        }
    }

    public class Line<T>                 // клас лінії																																					
    {
        public Point2D<T> A { get; set; }
        public Point2D<T> B { get; set; }

        public Line(Point2D<T> a, Point2D<T> b)
        {
            A = a;
            B = b;
        }

        public Line(T a, T b, T c, T d)
        {
            A = new Point2D<T>(a, b);
            B = new Point2D<T>(c, d);
        }

        public Line()
        {
            T A = default(T);
            T B = default(T);
        }

        public override string ToString()
        {
            return $"point A ({A.ToString()}), point B ({B.ToString()})";
        }
    }

    //--------------------------------------------------------------------------------------------------------																																					
    class Program
    {
        static void Main(string[] args)
        {

            NumberFormatInfo number = new NumberFormatInfo()            // встановлення розділового знаку для double																																					
            {
                NumberDecimalSeparator = ".",
            };

            int index;
            do                          // загальний цикл програми																																					
            {
                Console.Write("\n\nIs your line int (1) or double (other digit)?  ");
                index = Convert.ToInt32(Console.ReadLine());

                if (index == 1)
                {
                    int x, y;
                    Console.Write("\nPoint A, x = ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Point A, y = ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Point2D<int> pointA = new Point2D<int>(x, y);

                    Console.Write("Point B, x = ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Point B, y = ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Point2D<int> pointB = new Point2D<int>(x, y);

                    Line<int> line = new Line<int>(pointA, pointB);

                    Console.WriteLine("\nYour line (int) on the Cartesian coordinate system is: ");
                    Console.WriteLine(line.ToString());
                }

                else
                {
                    double x, y, i, j;
                    Console.Write("\n\nPoint A, x = ");
                    x = Convert.ToDouble(Console.ReadLine(), number);
                    Console.Write("Point A, y = ");
                    y = Convert.ToDouble(Console.ReadLine(), number);
                    Console.Write("Point B, x = ");
                    i = Convert.ToDouble(Console.ReadLine(), number);
                    Console.Write("Point B, y = ");
                    j = Convert.ToDouble(Console.ReadLine(), number);

                    Line<double> line = new Line<double>(x, y, i, j);

                    Console.WriteLine("\nYour line (double) on the Cartesian coordinate system is: ");
                    Console.WriteLine(line.ToString());
                }

                //--------------------------------------------------------------------------------------------------------																																					

                // продовжити ?																																					
                Console.Write("\n\nDo you want to continue? ('1' for 'yes'): ");
                index = Convert.ToInt32(Console.ReadLine());

            } while (index == 1);
        }
    }
}
