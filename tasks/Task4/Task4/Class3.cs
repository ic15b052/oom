using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task4
{
    public class Planet : StellarBody
    {
        private string ID;


        [JsonConstructor]
        public Planet(decimal Mass, decimal Distance, string Name)
        {
            if (Mass < 0) throw new ArgumentOutOfRangeException("Mass must not be negative.");
            if (Distance < 0) throw new ArgumentOutOfRangeException("Distance must not be negative.");
            if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentOutOfRangeException("Name must be given");

            this.Name = Name;
            this.Mass = Mass;
            Distance_to_sun = Distance;
            GenerateID();

        }


        public decimal Mass { get; }

        public decimal Distance_to_sun { get; set; }

        public string Name { get; }

        public void GenerateID()
        {
            ID = Name + Distance_to_sun;
        }

        public void Update_Distance(decimal newDistance)
        {
            if (newDistance < 0) throw new ArgumentOutOfRangeException("Distance must not be negative.");
            Distance_to_sun = newDistance;
        }


    }
}
