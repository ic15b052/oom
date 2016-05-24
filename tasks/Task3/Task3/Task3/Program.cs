using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{   
    public interface StellarBody
    {

        string Name { get; }

        decimal Mass { get; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            var Bodies = new StellarBody[]
            {
                new Planet(100000, 4770000, "A1B052"),
                new Sun(7563458, "Perseus",Type.Giant),
                new Planet(1000000, 45000, "B745C34"),
                new Sun(99999999, "Frankenstein",Type.redDwarf),
                new Planet(8450000, 121230000, "JFHD34"),
            };


            foreach(var x in Bodies)
            {
                Console.WriteLine("Name: {0} Mass: {1}",x.Name,x.Mass);
            }




        }
    }

    public class Planet : StellarBody
    {
        private decimal Distance_to_sun;

        public Planet(decimal newMass, decimal newDistance, string newName)
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

    public class Sun : StellarBody
    {
        private Type Classification;

        public Sun(decimal newMass, string newName, Type classification)
        {
            if (newMass < 0) throw new ArgumentOutOfRangeException("Mass must not be negative.");
            if (newName == null) throw new ArgumentOutOfRangeException("Name must be given");

            Name = newName;
            Mass = newMass;
            Classification = classification;
  
        }


        public string Name { get; }

        public decimal Mass { get; }

        public bool verifyClassification(Type checkClassification)
        {
            if (Classification == checkClassification)
                return true;
            else
                return false;
        }


    }

    public enum Type
    {
        whiteDwarf,
        redDwarf,
        Giant,
        BrightGiant,
        Hypergiant
    }
}
