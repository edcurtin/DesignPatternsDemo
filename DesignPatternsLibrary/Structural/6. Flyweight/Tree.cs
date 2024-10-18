﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._6._Flyweight
{
    public class Tree
    {
        private int x, y;
        private TreeType treeType;

        public Tree(int x, int y, TreeType treeType)
        {
            this.x = x;
            this.y = y;
            this.treeType = treeType;
        }

        public void Draw()
        {
            treeType.Draw(x, y);
        }
    }
}
