using System;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcTriangle(); // Here methods are called
            CalcCircle();
        }

        /*All the methods are defined here*/
        static void CalcTriangle()
        {
            Console.WriteLine("Введите длину первой стороны");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину третьей стороны");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите единицы измерения");
            string mes = Console.ReadLine();



            double v = (a + b + c);
            double p = v / 2;
            double sq = p * (p - a) * (p - b) * (p - c);
            double area = Math.Sqrt(sq);

            Console.WriteLine($"площадь треугольника равна {area} кв. {mes}");

        }

        static void CalcCircle()
        {
            Console.WriteLine("Введите диаметр окружности");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите единицы измерения");
            string mes = Console.ReadLine();

            double area = (3.14 * d * d) / 4;

            Console.WriteLine($"площадь круга равна {area} кв. {mes}");
        }
    }
}
