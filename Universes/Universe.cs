using System;
using System.Collections.Generic;
using System.Text;
using Corbeille3._2._3.Elements;

namespace Corbeille3._2._3.Universes
{
    class Universe
    {
        private int height;
        private int width;
        private IElement[,] universeGrid;

        public int Height { get => height; }
        public int Width { get => width; }
        public IElement[,] UniverseGrid { get => universeGrid; }

        public Universe(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.universeGrid = new IElement[height, width];
        }
    }
}
