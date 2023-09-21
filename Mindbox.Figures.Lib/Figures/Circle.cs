using Mindbox.Figures.Lib.Figures.Abstract;
using static Mindbox.Figures.Lib.Configuration.AppConstants;

namespace Mindbox.Figures.Lib.Figures
{
    /// <summary>
    /// Окружность.
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="radius">Длина радиуса окружности.</param>
        /// <exception cref="ArgumentException">Radius of circle cannot be 0 or negative.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException(FigureExceptionMessages.RadiusCannotBeNullOrNegative);
            Radius = radius;
        }

        /// <summary>
        /// Получить площадь окружности.
        /// </summary>
        /// <returns>Площадь окружности.</returns>
        public override double GetArea() => Math.Round((Math.PI * Math.Pow(Radius, 2)), DigitsAfterDecimalPoint);
    }
}
