namespace Corbeille3._2._3.Elements
{
    public class AtomicMass
    {
        private double mass;
        private string unit;

        public double Mass { get => mass; }
        public string Unit { get => unit; }
        public string GetAtomicMass { get => mass + " " + unit; }

        public AtomicMass(string atomicMass)
        {
            mass = int.Parse(atomicMass.Split(" ")[0]);
            unit = atomicMass.Split(" ")[1];
        }
    }
}
