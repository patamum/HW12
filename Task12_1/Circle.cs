using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    static class Circle
    {
        static public double GetLenthCircle(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquareCircle(double r)
        {
            return Math.PI * r * r;
        }
        static public string InCircle(int x, int y, int r, int x0, int y0)
        {
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= r * r)
                return $"точка ({x}, {y}) принадлежит кругу радиусом {r}";
            return $"точка ({x}, {y}) не принадлежит кругу радиусом {r}";
        }
    }
}
