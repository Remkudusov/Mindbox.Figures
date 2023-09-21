using Mindbox.Figures.Lib.Figures;
using Mindbox.Figures.Lib.Figures.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Figures.Tests
{
    /// <summary>
    /// Тест рассчёта площади фигур.
    /// </summary>
    public class AreaTest
    {
        /// <summary>
        /// Проверить правильность рассчёта площади фигуры.
        /// </summary>
        [Fact(DisplayName = "Проверить правильность рассчёта площади фигуры.")]
        public void CheckAreaCalculations()
        {
            var figureAreas = new Dictionary<double, Figure>()
            {
                { 24, new Triangle(6, 8, 10) },
                { 59.81168, new Triangle(10, 12, 15) },
                { 14102.60942, new Circle(67) },
            };

            foreach (var figureArea in figureAreas)
                Assert.Equal(figureArea.Key, figureArea.Value.GetArea());
        }
    }
}
