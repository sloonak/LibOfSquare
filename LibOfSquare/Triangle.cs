

namespace LibOfSquare
{
    public class Triangle
    {
        double first, second, third;

        public Triangle(double first, double second, double third)
        {
            First = first;
            Second = second;
            Third = third;
        }
        public double First
        {
            get { return first; }
            set { first = value < 0 ? -value : value; }
        }
        public double Second
        {
            get { return second; }
            set { second = value < 0 ? -value : value; }
        }
        public double Third
        {
            get { return third; }
            set { third = value < 0 ? -value : value; }
        }
        public string CheckOfTriangle() // подумал что лучше возвращать строковое значение, в случае чего можно поменять на булевое
        {
            if ((first * first + second * second == third * third) ||
                (first * first + third * third == second * second) ||
                (third * third + second * second == first * first))
            {
                return "Это прямоугольный треугольник";
            }
            return "Это не прямоугольный треугольник";
        }
    }
}
