using System;
using System.Collections.Generic;
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
            ElementAdded += UniverseEvents.OnElementAdded;
            ElementRemoved += UniverseEvents.OnElementRemoved;
        }

        public void InsertElement(IElement element, int x, int y)
        {
            CheckElement(element);
            CheckInBounds(x, y);
            CheckPosition(x, y);
            universeGrid[x, y] = element;
            ElementAdded?.Invoke(this, EventArgs.Empty);
        }

        public void InsertElement(IElement element, Point point)
        {
            InsertElement(element, point.X, point.Y);
        }

        public void RemoveElement(int x, int y)
        {
            CheckInBounds(x, y);
            universeGrid[x, y] = null;
            ElementRemoved?.Invoke(this, EventArgs.Empty);
        }

        public void RemoveElement(Point point)
        {
            RemoveElement(point.X, point.Y);
        }

        public IElement[] GetElements()
        {
            List<IElement> elements = new List<IElement>();
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    if (universeGrid[x, y] != null)
                        elements.Add(universeGrid[x, y]);
            return elements.ToArray();
        }

        public IElement GetElement(int x, int y)
        {
            return universeGrid[x, y];
        }

        public IElement GetElement(Point point)
        {
            return GetElement(point.X, point.Y);
        }

        public void Show()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                    if (universeGrid[x, y] != null)
                        Console.Write(universeGrid[x, y].Symbol + "\t");
                    else
                        Console.Write("_\t");
                Console.WriteLine("\n");
            }
        }

        private void CheckElement(IElement element)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    if (universeGrid[x, y] != null && universeGrid[x, y].Symbol == element.Symbol)
                        throw new ElementAlreadyInUniverseException();
                }
        }

        private void CheckPosition(int x, int y)
        {
            if (universeGrid[x, y] != null)
                throw new ElementAlrearyAtThisPositionInUniverseException();
        }

        private void CheckInBounds(int x, int y)
        {
            if (x >= width || x < 0 || y >= height || y < 0)
                throw new ElementIsOutsideUniverseException();
        }

        public event EventHandler ElementAdded;
        public event EventHandler ElementRemoved;
    }
}
