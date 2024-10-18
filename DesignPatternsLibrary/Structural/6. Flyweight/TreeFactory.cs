using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._6._Flyweight
{
    public class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}_{color}_{texture}";

            if (!treeTypes.ContainsKey(key))
            {
                treeTypes[key] = new TreeType(name, color, texture);
            }

            return treeTypes[key];
        }
    }
}
