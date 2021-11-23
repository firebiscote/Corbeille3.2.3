namespace Corbeille3._2._3.Elements
{
    public class Element : IElement
    {
        private string atom;
        private char symbol;
        private AtomicMass atomicMass;

        public string Atom { get => atom; }
        public char Symbol { get => symbol; }
        public AtomicMass AtomicMass { get => atomicMass; }

        public Element(string atom, char symbol, AtomicMass atomicMass)
        {
            this.atom = atom;
            this.symbol = symbol;
            this.atomicMass = atomicMass;
        }

        public Element(string atom, char symbol, string atomicMass)
        {
            this.atom = atom;
            this.symbol = symbol;
            this.atomicMass = new AtomicMass(atomicMass);
        }
    }
}
