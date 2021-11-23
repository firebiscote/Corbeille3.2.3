using System;

namespace Corbeille3._2._3.Elements
{
    public interface IElement
    {
        public string Symbol { get; }
        public event EventHandler ElementMoved;

        public void Move();
    }
}
