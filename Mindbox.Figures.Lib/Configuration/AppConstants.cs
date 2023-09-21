using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Figures.Lib.Configuration
{
    /// <summary>
    /// Константы библиотеки.
    /// </summary>
    public static class AppConstants
    {
        public static class FigureExceptionMessages
        {
            public const string TriangleSideCannotBeNullOrNegative = "Triangle side length cannot be 0 or negative.";
            public const string IncorrectRelationshipBetweenSides = "Incorrect relationship between the sides of the triangle (sum of the lengths of any two sides of triangle must be greater than the length of the third side).";
            public const string RadiusCannotBeNullOrNegative = "Radius of circle cannot be 0 or negative.";
        }

        public const double Accurancy = 0.00001;
        public const int DigitsAfterDecimalPoint = 5;
    }
}
