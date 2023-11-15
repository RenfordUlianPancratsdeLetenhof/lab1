using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Building
    {
        public string Name { get; set; }

        public abstract double CalculateFoundationHeight();

        public abstract string DisplayInfo();
    }
}
