using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculatingShapeValues
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Свойство Radius, для хранения значения радиуса круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор, для проверки условий и установки значения радиуса
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным или быть равным 0", nameof(radius));
            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга через радиус
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var area = Math.PI * Math.Pow(Radius, 2d);

            return area;
        }

        /// <summary>
        /// Вычисление периметра круга
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            var perimeter = 2 * Math.PI * Radius;

            return perimeter;
        }
    }
}
