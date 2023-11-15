using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Office : Building
    {
        public int NumberOfFloors { get; set; }

        public override double CalculateFoundationHeight()
        {
            return 0.05 * NumberOfFloors;
        }

        public override string DisplayInfo()
        {
            return $"Building: {Name}\nType: Office | Number of Floors: {NumberOfFloors}";
        }
    }
}
