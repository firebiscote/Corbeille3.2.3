using System;

namespace Corbeille3._2._3.Universes
{
    public class ElementAlreadyInUniverseException : Exception
    {
        public ElementAlreadyInUniverseException() { }
    }

    public class ElementIsOutsideUniverseException : Exception
    {
        public ElementIsOutsideUniverseException() { }
    }

    public class ElementAlrearyAtThisPositionInUniverseException : Exception
    {
        public ElementAlrearyAtThisPositionInUniverseException() { }
    }
}
