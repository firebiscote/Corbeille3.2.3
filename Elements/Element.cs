using System;
using Corbeille3._2._3.Universes;

namespace Corbeille3._2._3.Elements
{
    public class Element : IElement
    {
        private string atom;
        private string symbol;
        private AtomicMass atomicMass;

        public string Atom { get => atom; }
        public string Symbol { get => symbol; }
        public AtomicMass AtomicMass { get => atomicMass; }

        public Element(string atom, string symbol, AtomicMass atomicMass)
        {
            this.atom = atom;
            this.symbol = symbol;
            this.atomicMass = atomicMass;
            ElementMoved += UniverseEvents.OnElementMoved;
        }

        public Element(string atom, string symbol, string atomicMass)
        {
            this.atom = atom;
            this.symbol = symbol;
            this.atomicMass = new AtomicMass(atomicMass);
        }

        public void Move()
        {
            ElementMoved?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ElementMoved;
    }
}
