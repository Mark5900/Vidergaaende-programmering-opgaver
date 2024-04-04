using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skove
{
    internal class ForestArea
    {
        public string Name { get; set; }
        public Decimal Area { get;  private set; }
        public int Trees { get; private set; }
        private string TreeType;
    
        public ForestArea(string name, Decimal area, int trees, string treeType)
        {
            Name = name;
            Area = area;
            Trees = trees;
            TreeType = treeType;
        }
        public void AddTrees(int trees)
        {
            Trees += trees;
        }
    }
}
