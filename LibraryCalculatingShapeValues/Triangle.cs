using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCalculatingShapeValues
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private readonly Lazy<bool> _rightTriangle;
        bool RightTriangle => _rightTriangle.Value;

        /// <summary>
        /// Конструктор, для проверки и установления значений сторон
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException("Сторона не может быть отрицательной, либо равной 0", nameof(sideA));
            }
            if (sideB <= 0)
            {
                throw new ArgumentException("Сторона не может быть отрицательной, либо равной 0", nameof(sideB));
            }
            if (sideC <= 0)
            {
                throw new ArgumentException("Сторона не может быть отрицательной, либо равной 0", nameof(sideC));
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            _rightTriangle = new Lazy<bool>(GetRightTriangle);
        }
        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool GetRightTriangle()
        {
            var rightTriangle = (SideA * SideA + SideB * SideB == SideC * SideC) || (SideA * SideA + SideC * SideC == SideB * SideB) || (SideB * SideB + SideC * SideC == SideA * SideA);

            return rightTriangle;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2d;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));

            return area;
        }

        /// <summary>
        /// Вычисление периметра треугольника
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            var perimeter = SideA + SideB + SideC;

            return perimeter;
        }
    }
}
