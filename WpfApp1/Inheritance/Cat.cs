using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Inheritance
{
    class Cat : Animal
    {
        private string _breed;

        public string breed { get { return _breed; } set { _breed = value; } }

        public Cat(string name, double growth, string breed, int k) : base(k)
        {
            this.name = name;
            this.growth = growth;
            this.breed = breed;

        }

        public override double weight_of_animal()
        {
            double weight = base.weight_of_animal();
            double weight_grams = weight * 1000;
            return weight;
        }

    }
}