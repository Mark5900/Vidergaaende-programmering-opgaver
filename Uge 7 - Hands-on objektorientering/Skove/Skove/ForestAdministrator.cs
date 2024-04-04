using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skove
{
    internal class ForestAdministrator
    {
        private List<ForestArea> Areas;

        public ForestAdministrator()
        {
            Areas = new List<ForestArea>();
        }

        public void AddAccess(ForestArea area)
        {
            Areas.Add(area);
        }
        public bool HasAccessToArea (ForestArea area)
        {
            return Areas.Contains(area);
        }
    }
}
