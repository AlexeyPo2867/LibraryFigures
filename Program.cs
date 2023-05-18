namespace LibraryFigures
{
    internal class Program
    {
        class Programm
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Geometry.GetCircleArea(5)); // 78.53981633974483
                Console.WriteLine(Geometry.GetTriangleArea(3, 4, 5)); // 6
                Console.WriteLine(Geometry.IsRightAngledTriangle(3, 4, 5)); // True

                double? area = Geometry.GetArea(5.0);

                if (area.HasValue)
                {
                    Console.WriteLine("Площадь круга: " + area.Value);
                }
                
                area = Geometry.GetArea(3.0, 4.0, 5.0);
                if (area.HasValue)
                {
                    Console.WriteLine("Площадь треугольника: " + area.Value);
                }

            }
        }
    }
}