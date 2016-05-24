using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    public class Sun : StellarBody
    {
        private string ID;

        [JsonConstructor]
        public Sun(decimal newMass, string newName, Type classification)
        {
            if (newMass < 0) throw new ArgumentOutOfRangeException("Mass must not be negative.");
            if (newName == null) throw new ArgumentOutOfRangeException("Name must be given");

            Name = newName;
            Mass = newMass;
            Classification = classification;
            GenerateID();

        }

        public string Name { get; }

        public decimal Mass { get; }

        public Type Classification { get; }

        public bool verifyClassification(Type checkClassification)
        {
            if (Classification == checkClassification)
                return true;
            else
                return false;
        }

        public void GenerateID()
        {
            ID = Name + Classification;
        }


    }
}
