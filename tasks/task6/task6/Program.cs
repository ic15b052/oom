using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using static System.Console;
using System.Reactive.Subjects;

namespace task6
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

            /*
            var testBody = new Planet(100000, 4770000, "A1B052");
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };

            Console.WriteLine(JsonConvert.SerializeObject(Bodies, settings));


            var text = JsonConvert.SerializeObject(Bodies, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

           
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<StellarBody[]>(textFromFile, settings);
            */

            // Pulling:

            WriteLine("foreach bodies to was:");
            IEnumerable<StellarBody> tester = Bodies;

            foreach (var x in tester)
                WriteLine(JsonConvert.SerializeObject(x));

            // enumerator händisch wurschteln
            var e = tester.GetEnumerator();
            while (e.MoveNext())
            {
                WriteLine(JsonConvert.SerializeObject(e.Current));
            }


            //push.gogo();

            Tasks.gogo();
            


        }
    }




}
