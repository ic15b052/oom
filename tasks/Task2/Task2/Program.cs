using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Planets = new[]
            {
                new Planet(100000, 4770000, "A1B052"),
                new Planet(110000, 9480000, "A2B352"),
                new Planet(1000000, 45000, "B745C34"),
                new Planet(230000, 120045600, "234G84"),
                new Planet(8450000, 121230000, "JFHD34"),
            };

            foreach (var b in Planets)
            {
                Console.WriteLine("Mass: {0} Name: {1} Distance {2}", b.Mass, b.Name, b.GetDistance());
            }


            Planets[1].Update_Distance(2);
            Planets[4].Update_Distance(2125);

            foreach (var b in Planets)
            {
                Console.WriteLine("Mass: {0} Name: {1} Distance {2}", b.Mass, b.Name, b.GetDistance());
            }




        }
    }

    public class Planet
    {
        private decimal Distance_to_sun;

        public Planet(decimal newMass,decimal newDistance, string newName)
        {
            if (newMass < 0) throw new ArgumentOutOfRangeException("Mass must not be negative.");
            if (newDistance < 0) throw new ArgumentOutOfRangeException("Distance must not be negative.");
            if (newName == null) throw new ArgumentOutOfRangeException("Name must be given");

            Name = newName;
            Mass = newMass;
            Distance_to_sun = newDistance;

        }

        public decimal Mass { get; }


        public string Name { get; }

        public decimal GetDistance()
        {
            return Distance_to_sun;

        }

        public void Update_Distance(decimal newDistance)
        {
            if (newDistance < 0) throw new ArgumentOutOfRangeException("Distance must not be negative.");
            Distance_to_sun = newDistance;
        }


    }
}
