using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        private static int planet;

        static void Main(string[] args)
        {
List<string> planetList = new List<string>(){
    "Mercury", "Mars"
    };
    planetList.Add("Jupiter");
        planetList.Add("Saturn");
            planetList.ForEach(planet => Console.WriteLine(planet));

List<string> solarSystem = new List<string>(){
    "Jupiter",
     "Saturn"
    };
    //Combining the two list by AddRange
            solarSystem.AddRange(planetList);
            //inserting the planet according to right order
            solarSystem.Insert(3,"Venus");
            solarSystem.Insert(4,"earth");
            //adding dwarf planet pluto
            solarSystem.Add("Pluto");
            //deleting dwarf planet pluto
                        solarSystem.Remove("Pluto");



            

            solarSystem.ForEach(planets => Console.WriteLine(planets));

//Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets
List<string> rockyPlanet = solarSystem.GetRange(1,4);
rockyPlanet.ForEach(planet=>Console.WriteLine(planet));







        }
    }
}
