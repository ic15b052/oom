using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{

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


            var testBody = new Planet(100000, 4770000, "A1B052");

         
            Console.WriteLine(JsonConvert.SerializeObject(testBody));

          
            Console.WriteLine(JsonConvert.SerializeObject(testBody, Formatting.Indented));
            
            // 3. serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(Bodies, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(Bodies, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);
            
            // 5. deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<StellarBody[]>(textFromFile, settings);
            





        }
    }




}
