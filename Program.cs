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



            

            solarSystem.ForEach(planet => Console.WriteLine(planet));

//Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets
List<string> rockyPlanet = solarSystem.GetRange(1,4);
rockyPlanet.ForEach(planet=>Console.WriteLine(planet));


List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
           Dictionary<string, string> Mercury = new Dictionary<string, string>{{"Mercury", "Mernier 10"}};

 Dictionary<string,string> Venus = new Dictionary<string, string>{{"Venus", "Cosmos 21"}};
   Dictionary<string, string> Mars = new Dictionary<string, string>{{"Mars", "Viking"}};
    Dictionary<string, string> Cosmos21 = new Dictionary<string, string>() {{ "Mars", "Cosmos 21" } };
        Dictionary<string, string> Cassini = new Dictionary<string, string>() {{ "Mercury", "Cassini" } };


     Dictionary<string, string> Jupiter = new Dictionary<string, string>{{"Jupiter", "Pioneer 11"}};
      Dictionary<string, string> Saturn = new Dictionary<string, string>{{"Saturn", "Cassini"}};
        Dictionary<string, string> Uranus = new Dictionary<string, string>{{"Uranus", "Voyager 2"}};
           Dictionary<string, string> Neptune = new Dictionary<string, string>{{"Neptune", "Voyager 2"}};
           probes.Add(Mercury);
            probes.Add(Mars);
           probes.Add(Jupiter);
           probes.Add(Saturn);
           probes.Add(Uranus);
           probes.Add(Neptune);
        probes.Add(Venus);
        probes.Add(Cosmos21);
                probes.Add(Cassini);



            foreach (string planet in solarSystem)
            {
                // Build an initial list of string to hold the matching probe names
                List<string> visitedProbes = new List<string>();

                // Iterate over all the probes
                foreach (Dictionary<string, string> probe in probes)
                {
                    /*
                        Does the current planet name in the dictionary match
                        the name of the planet in the planet list
                     */
                    if (probe.ContainsKey(planet)) {
                        visitedProbes.Add(probe[planet]);
                    }

                }

                // Output the name of the planet and comma separated list of matching probes
                Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
            }
        }
    }
}



