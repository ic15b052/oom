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
        public Sun(decimal Mass, string Name, Type Classification)
        {
            if (Mass < 0) throw new ArgumentOutOfRangeException("Mass must not be negative.");
            if (Name == null) throw new ArgumentOutOfRangeException("Name must be given");

            this.Name = Name;
            this.Mass = Mass;
            this.Classification = Classification;
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
