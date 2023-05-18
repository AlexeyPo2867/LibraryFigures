using Xunit;

namespace LibraryFigures
{
    public class GeometryTest
    {
        [Fact]
        public void GetCircleAreaTest()
        {
            double radius = 5;
            double expected = Math.PI * radius * radius;
            double actual = Geometry.GetCircleArea(radius);
        }

        [Fact]
        public void GetTriangleAreaTest()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double p = (side1 + side2 + side3) / 2;
            double expected = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            double actual = Geometry.GetTriangleArea(side1, side2, side3);
        }

        [Fact]
        public void IsRightAngledTriangleTest()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            bool expected = true;
            bool actual = Geometry.IsRightAngledTriangle(side1, side2, side3);

            side1 = 5;
            side2 = 12;
            side3 = 13;
            expected = true;
            actual = Geometry.IsRightAngledTriangle(side1, side2, side3);

            side1 = 3;
            side2 = 5;
            side3 = 7;
            expected = false;
            actual = Geometry.IsRightAngledTriangle(side1, side2, side3);
        }
    }
}
