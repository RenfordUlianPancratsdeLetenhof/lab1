using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Inheritance
{
    class Animal
    {
        private string _name;
        private double _growth;
        private int _k { get; set; }

        public string name { get { return _name; } set { _name = value; } }
        public double growth { get { return _growth; } set { _growth = value; } }

        public Animal(int k)
        {
            _k = k;
        }

        public virtual double weight_of_animal()
        {
            return _k * Math.Pow(growth, 3);
        }

        public string Print_name()
        {
            return name;
        }

        public double Print_growth()
        {
            return growth;
        }
    }
}