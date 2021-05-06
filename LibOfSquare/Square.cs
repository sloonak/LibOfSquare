using System;

namespace LibOfSquare
{
    public class Square
    {
        public double SquareOfCircleFromRadius(double r)
        {
            double square = Math.PI * Math.Pow(r,2);
            return square;
        }
        public double SquareOfCircleFromTriangle(Triangle triangle)
        {
            double first_side = triangle.First;
            double second_side = triangle.Second;
            double third_side = triangle.Third;

            double p = (first_side + second_side + third_side) / 2;  //полусумма всех сторон
            double r = (first_side * second_side * third_side) / (4 * Math.Sqrt(p * (p - first_side) * (p - second_side) * (p - third_side)));
            return SquareOfCircleFromRadius(r);
        }
    }
}
