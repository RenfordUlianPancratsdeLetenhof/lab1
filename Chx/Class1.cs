using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace lab5
{
    public class ChxCalculator
    {
        private double x;
        private double sqr;
        private double min = 0.001;

        public ChxCalculator()
        {
            x = 0;
        }

        public ChxCalculator(double xx)
        {
            x = xx;
            sqr = x * x;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double ChxCycle()
        {
            double sum = x;
            double current = x;
            int n = 3;
            int mul = -1;

            do
            {
                current = current * sqr / n++ / (n - 1);
                sum = sum + mul * current;
                mul = -mul;
            } while (Math.Abs(current) > min);

            return sum;
        }

        public void ChxRecursive(double current, double mul, double n, ref double sum)
        {
            current = current * sqr / n++ / (n - 1);
            sum = sum + mul * current;
            mul = -mul;

            if (Math.Abs(current) > min)
                ChxRecursive(current, mul, n, ref sum);
        }
    }
}

