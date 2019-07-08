using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            Console.WriteLine("Planet List First");
            planetList.ForEach(planet => Console.WriteLine(planet));
            // 1. Add Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            Console.WriteLine("Planets after adding.");
            planetList.ForEach(planet => Console.WriteLine(planet));
            //2. Create another List that contains the last two planets of our solar system.
            List<string> newPlanetList = new List<string>() {"Uranus", "Neptune"};
            Console.WriteLine("New Planet List");
            newPlanetList.ForEach(planet => Console.WriteLine(planet));
            // 3. Combine the two lists by using AddRange().
            planetList.AddRange(newPlanetList);
            Console.WriteLine("Combined Planets");
            planetList.ForEach(planet => Console.WriteLine(planet));
            // 4. Use Insert () to Add Earth and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            Console.WriteLine("Added Earth and Venus");
            planetList.ForEach(planet => Console.WriteLine(planet));
            //5. Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            Console.WriteLine("Added pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called Rockyplanets. The rocky planets will remain in the original planets list.
            List<String> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("Rockyplanet");
            rockyPlanets.ForEach(rocky => Console.WriteLine(rocky));
            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to elimanate it from the end of the planetList.
            planetList.Remove("Pluto");

            Console.WriteLine("BEGONE PLUTHOT");
            planetList.ForEach(planet => Console.WriteLine(planet));


        }
    }
}
