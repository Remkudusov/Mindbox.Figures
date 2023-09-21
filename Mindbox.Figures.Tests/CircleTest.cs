using Mindbox.Figures.Lib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mindbox.Figures.Lib.Configuration.AppConstants;

namespace Mindbox.Figures.Tests
{
    /// <summary>
    /// Тест работы с окружностью.
    /// </summary>
    public class CircleTest
    {
        /// <summary>
        /// Проверить корректность инициализации окружности с радиусом негативной или нулевой длины.
        /// </summary>
        [Fact(DisplayName = "Проверить корректность инициализации окружности с радиусом негативной или нулевой длины.")]
        public void CheckCircleNullOrNegativeRadiusInitialization()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(-1));
            Assert.Equal(FigureExceptionMessages.RadiusCannotBeNullOrNegative, exception.Message);
        }
    }
}
