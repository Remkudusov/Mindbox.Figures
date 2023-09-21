using Mindbox.Figures.Lib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Figures.Lib.Figures.Abstract
{
    /// <summary>
    /// Фигура.
    /// </summary>
    public abstract class Figure : IAreaFinder
    {
        /// <inheritdoc />
        public abstract double GetArea();
    }
}
