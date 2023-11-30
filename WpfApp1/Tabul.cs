using lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    internal class Tabul
    {
        public List<Point> Points = new List<Point>();

        public void Add(Point point)
        {
            Points.Add(point);
        }

        public void GetList(double xn, double xk, double h)
        {
            try
            {
                var x = xn;
                double y = 0, yCycle = 0, yRecursive = 0;

                while (x < xk)
                {
                    var chxCalculator = new ChxCalculator(x);
                    y = x; 
                    yCycle = chxCalculator.ChxCycle();
                    yRecursive = 0;
                    chxCalculator.ChxRecursive(x, 1, 3, ref yRecursive);

                    var point = new Point(x, y, yCycle, yRecursive);
                    Add(point);

                    x += h;
                }
            }
            catch (Exception ex) { }
        }
    }
}
