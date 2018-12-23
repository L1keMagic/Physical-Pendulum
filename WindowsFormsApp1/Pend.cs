using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Pend
    {
        public double m;
        double d;
        double i;
        public double a;
        public double l;
        double x1, x2, dx, y, y1, xend;
        public double T, I, L;

        public Pend()
        {
            a = 0; // От подвеса да верхнего края (Не делай больше длины или будет очень весело)
            m = 5; // масса (влияет только на скорость стухливания)
            Random r = new Random();
            L = r.Next(5, 15);
            L /= 10; // Длина в метрах
            l = L * 100 * 1.062; // Корректировка
            T = 2 * Math.PI * Math.Sqrt(l / (3 * 10)); // Период
            I = m * l * l / 3; // Момент инерции
            xend = 60;
            x1 = 0;
            x2 = 0;
            y = 30; // начальный угол
            y1 = 0;
            dx = 1;
            d = l / 2 - a;
            i = ((m * l * l) / 12) + (m * d * d);
            y1 = y1 + f(y, m, d, i) * dx / 2;
            y = y + y1 * dx;
            x1 += dx;
        }

        double f(double y, double m, double d, double i)
        {
            return ((-m * 9.8 * d) * Math.Sin(y * Math.PI / 180)) / i;
        }

        public double count()
        { // метод половинного интеграла
            y1 = y1 + f(y, m, d, i) * dx;
            y = y + y1 * dx;
            x1 += dx;
            return y;//*Math.Exp(-0.004*x1);
        }

    }
}
