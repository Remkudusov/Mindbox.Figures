using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Figures.Lib.Services
{
    /// <summary>
    /// Сервис для нахождения площади фигуры.
    /// </summary>
    public interface IAreaFinder
    {
        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double GetArea();
    }
}
