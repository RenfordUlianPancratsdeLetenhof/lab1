using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Factory : Building
    {
        public int NumberOfWorkshops { get; set; }

        public override double CalculateFoundationHeight()
        {
            return 0.000002 * NumberOfWorkshops;
        }

        public override string DisplayInfo()
        {
            return $"Building: {Name}\nType: Factory | Number of Workshops: {NumberOfWorkshops}";
        }
    }
}
