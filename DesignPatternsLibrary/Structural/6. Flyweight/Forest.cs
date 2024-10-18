using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._6._Flyweight
{
    public class Forest
    {
        private List<Tree> trees = new List<Tree>();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType treeType = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new Tree(x, y, treeType);
            trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in trees)
            {
                tree.Draw();
            }
        }
    }
}
