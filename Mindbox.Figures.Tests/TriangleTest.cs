using Mindbox.Figures.Lib.Figures;
using static Mindbox.Figures.Lib.Configuration.AppConstants;

namespace Mindbox.Figures.Tests
{
    /// <summary>
    /// Тест работы с треугольником.
    /// </summary>
    public class TriangleTest
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Проверить корректность соотношения между сторонами треугольника.
        /// </summary>
        [Fact(DisplayName = "Проверить корректность соотношения между сторонами треугольника.")]
        public void CheckRelationshipBetweenSides()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
            Assert.Equal(FigureExceptionMessages.IncorrectRelationshipBetweenSides, exception.Message);
        }

        /// <summary>
        /// Проверить корректность инициализации треугольника со стороной негативной или нулевой длины.
        /// </summary>
        [Fact(DisplayName = "Проверить корректность инициализации треугольника со стороной негативной или нулевой длины.")]
        public void CheckTriangleNullOrNegativeSidesInitialization()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 2));
            Assert.Equal(FigureExceptionMessages.TriangleSideCannotBeNullOrNegative, exception.Message);
        }

        /// <summary>
        /// Проверить является ли треугольник прямоугольным.
        /// </summary>
        [Fact(DisplayName = "Проверить является ли треугольник прямоугольным.")]
        public void CheckIsTriangleRightAngled()
        {
            var a = _random.NextDouble();
            var b = _random.NextDouble();
            var c = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), DigitsAfterDecimalPoint);
            Assert.True(Triangle.IsRightTriangle(new Triangle(a, b, c)));
        }
    }
}
