using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Polyminal
    {
        int a = 29;
        private double _a, _b, _c, _d;

        // Констурктор для введення із клави
        public Polyminal(double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }
        // Генератор рандому
        private void random(int min, int max)
        {
            Random rand = new Random();
            _a = rand.Next(min, max);
            _b = rand.Next(min, max);
            _c = rand.Next(min, max);
            _d = rand.Next(min, max);
        }

        // Конструктор для рандому
        public Polyminal(int min, int max) 
        {
            random(min, max);
        }

        // Конструктор для рандому у діапазоні від 0 до 100

        public Polyminal()
        {
            random(0, 100);
        }

        // Обчислення значення многочлена
        public double evaluate(double x)
        {
            return _a * Math.Pow(x, 3) + _b * Math.Pow(x, 2) + _c * x + _d;
        }

        // Додавання многочлена 

        public Polyminal adding(Polyminal second_polyminal)
        {
            double answer_polyminal_a = this._a + second_polyminal._a;
            double answer_polyminal_b = this._b + second_polyminal._b;
            double answer_polyminal_c = this._c + second_polyminal._c;
            double answer_polyminal_d = this._d + second_polyminal._d;

            return new Polyminal(answer_polyminal_a, answer_polyminal_b, answer_polyminal_c, answer_polyminal_d);

        }

        // Віднімання многочлена

        public Polyminal substract (Polyminal second_polyminal)
        {
            double answer_polyminal_a = this._a - second_polyminal._a;
            double answer_polyminal_b = this._b - second_polyminal._b;
            double answer_polyminal_c = this._c - second_polyminal._c;
            double answer_polyminal_d = this._d - second_polyminal._d;

            return new Polyminal(answer_polyminal_a, answer_polyminal_b, answer_polyminal_c, answer_polyminal_d);
        }

        // Виведення многочлена

        public string output_polyminal()
        {
            return $"{_a}x^3 + {_b}x^2 + {_c}x + {_d}";
        }
    }
}
