using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculatingShapeValues
{
    /// <summary>
    /// Интерфейс для вычисления значений различных фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод для получения площади
        /// </summary>
        /// <returns></returns>
        double GetArea();

        /// <summary>
        ///  Метод для получение периметра
        /// </summary>
        /// <returns></returns>
        double GetPerimeter();
    }
}
