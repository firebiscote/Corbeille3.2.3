using System;

namespace Corbeille3._2._3.Universes
{
    public static class UniverseEvents
    {
        public static void OnElementAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Element added !");
        }

        public static void OnElementRemoved(object sender, EventArgs e)
        {
            Console.WriteLine("Element removed !");
        }

        public static void OnElementMoved(object sender, EventArgs e)
        {
            Console.WriteLine("Element moved !");
        }
    }
}
