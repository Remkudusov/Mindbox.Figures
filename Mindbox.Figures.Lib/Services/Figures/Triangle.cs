using Mindbox.Figures.Lib.Figures.Abstract;
using static Mindbox.Figures.Lib.Configuration.AppConstants;

namespace Mindbox.Figures.Lib.Figures
{
    /// <summary>
    /// Треуголник.
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Сторона A.
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Сторона B.
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Сторона C.
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="a">Длина стороны А.</param>
        /// <param name="b">Длина стороны B.</param>
        /// <param name="c">Длина стороны C.</param>
        /// <exception cref="ArgumentException">Incorrect relationship between the sides of the triangle (sum of the lengths of any two sides of triangle must be greater than the length of the third side).</exception>
        /// <exception cref="ArgumentException">Triangle side cannot be 0 or negative.</exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException(FigureExceptionMessages.TriangleSideCannotBeNullOrNegative);

            if (a > b + c || b > a + c || c > a + b)
                throw new ArgumentException(FigureExceptionMessages.IncorrectRelationshipBetweenSides);

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Получить площадь трегольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public override double GetArea() => IsRightTriangle(this)
            ? GetRightAngleTriangleArea(this)
            : GetTriangleAreaByHeronFormula(this);

        /// <summary>
        /// Определить, является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="triangle">Треугольник.</param>
        /// <param name="accurancy">Точность.</param>
        /// <returns>Флаг того, является ли треугольник прямоугольным.</returns>
        public static bool IsRightTriangle(Triangle triangle, double accurancy = Accurancy)
        {
            var orderedSizes = new[] { triangle.A, triangle.B, triangle.C }.OrderBy(x => x).ToArray();
            var hypothenuse = Math.Sqrt(Math.Pow(orderedSizes[0], 2) + Math.Pow(orderedSizes[1], 2));
            var result = Math.Abs(hypothenuse - orderedSizes[2]).CompareTo(accurancy);
            return result <= 0;
        }

        /// <summary>
        /// Получить площадь прямоугольного треугольника.
        /// </summary>
        /// <param name="triangle">Треугольник.</param>
        /// <returns>Площадь треугольника.</returns>
        public static double GetRightAngleTriangleArea(Triangle triangle)
        {
            var orderedSizes = new[] { triangle.A, triangle.B, triangle.C }.OrderBy(x => x).ToArray();
            return Math.Round((orderedSizes[0] * orderedSizes[1]) / 2, DigitsAfterDecimalPoint);
        }

        /// <summary>
        /// Получить площадь треугольника по формуле Герона.
        /// </summary>
        /// <param name="triangle">Треугольник.</param>
        /// <returns>Площадь треугольника.</returns>
        public static double GetTriangleAreaByHeronFormula(Triangle triangle)
        {
            var s = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Round(Math.Sqrt(s * (s - triangle.A) * (s - triangle.B) * (s - triangle.C)), DigitsAfterDecimalPoint);
        }
    }
}
