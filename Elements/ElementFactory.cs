using System;

namespace Corbeille3._2._3.Elements
{
    public class ElementFactory
    {
        public static ElementFactory Instance = new ElementFactory();

        private ElementFactory() { }

        public IElement GetElement(string atom)
        {
            return (atom.ToLower()) switch
            {
                "carbone" => new Element("Carbone", "C", "12,01074 u"),
                "Hydrogène" => new Element("Hydrogène", "H", "1,00794 u"),
                "Lithium" => new Element("Lithium", "Li", "6,941 u"),
                _ => throw new Exception(atom + " didn't exist !"),
            };
        }
    }
}
