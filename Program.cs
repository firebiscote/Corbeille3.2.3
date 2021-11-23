using System;
using Corbeille3._2._3.Elements;
using Corbeille3._2._3.Universes;

namespace Corbeille3._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Universe newUniverse = new Universe(2, 2);
            newUniverse.InsertElement(ElementFactory.Instance.GetElement("Carbone"), 1, 1);
            newUniverse.Show();
        }
    }
}