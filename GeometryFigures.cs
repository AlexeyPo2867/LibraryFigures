using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigures
{
    public static class Geometry
    {
        // Площадь окружности

        public static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Площадь треугольника. Используем формулу Герона

        public static double GetTriangleArea(double side1, double side2, double side3)
        {
            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("Invalid triangle");
            }

            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        // Проверка треугольника на существование

        private static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2;
        }


        // Проверка треугольгика на прямоугольность

        public static bool IsRightAngledTriangle(double side1, double side2, double side3)
        {
            double temp;
            if (side1 < side2)
            {
                temp = side1;
                side1 = side2;
                side2 = temp;
            }
            if (side1 < side3)
            {
                temp = side1;
                side1 = side3;
                side3 = temp;
            }
            if (side1 * side1 == side2 * side2 + side3 * side3)
            {
                return true;
            }

            return false;
        }

        // Добавляем новую фигуру (Прямоугольник)

        public static double GetRectangleArea(double side1, double side2)
        {
            return side1 * side2;
        }

        /*
           Чтобы вычислять площадь фигуры без знания её типа в compile-time,
           можно добавить дополнительный метод, например, возвращающий значение `double?`:
           Этот метод принимает параметры в виде `object[]` и пытается определить тип фигуры, 
           вызывая соответствующий метод вычисления площади. Если тип фигуры определить не удалось, метод возвращает `null`. 
        */

        public static double? GetArea(params object[] sides)
        {
            if (sides == null || sides.Length == 0)
            {
                return null;
            }

            if (sides[0] is double radius)
            {
                return GetCircleArea(radius);
            }
            else if (sides.Length == 3 && sides[0] is double side1 &&
                     sides[1] is double side2 && sides[2] is double side3 && IsValidTriangle(side1, side2, side3))
            {
                return GetTriangleArea(side1, side2, side3);
            }
            else
            {
                return null;
            }
        }
    }
}

