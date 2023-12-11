using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_7
{
    public class Circle
    {
        // Властивості класу
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }

        // Конструктор класу
        public Circle(double centerX, double centerY, double radius)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }

        // Метод для перевірки, чи точка знаходиться всередині кола
        public bool IsPointInside(double x, double y)
        {
            return Math.Pow(x - CenterX, 2) + Math.Pow(y - CenterY, 2) <= Math.Pow(Radius, 2);
        }
    }

    public class Ring : Circle
    {
        public double InnerRadius { get; set; }
        public double OuterRadius { get; set; }

        // Конструктор класу Ring
        public Ring(double centerX, double centerY, double outerRadius, double innerRadius)
            : base(centerX, centerY, outerRadius)
        {
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        public new bool IsPointInside(double x, double y)
        {
            return Math.Pow(x - CenterX, 2) + Math.Pow(y - CenterY, 2) <= Math.Pow(OuterRadius, 2) && Math.Pow(x - CenterX, 2) + Math.Pow(y - CenterY, 2) >= Math.Pow(InnerRadius, 2);
        }
    }
}
