using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klimavenlig_mad
{
    internal class Food
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Co2_Agriculture { get; set; }
        public double Co2_Transport { get; set; }
        public double Co2_ILUC { get; set; }
        public double Co2_Processing { get; set; }
        public double Co2_Packaging { get; set; }
        public double Co2_Retail { get; set; }

        public double GetTotalCo2()
        {
            return Co2_Agriculture + Co2_Transport + Co2_ILUC + Co2_Processing + Co2_Packaging + Co2_Retail;
        }
    }
}
