using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using static System.Console;
using System.Reactive.Subjects;

namespace task6
{
    public static class push
    {
        public static void gogo()
        {
            var testinger = new Subject<StellarBody>();
            var Bodies = new List<StellarBody>
            {
                new Planet(100000, 4770000, "A1B052"),
                new Sun(7563458, "Perseus",Type.Giant),
                new Planet(1000000, 45000, "B745C34"),
                new Sun(99999999, "Frankenstein",Type.redDwarf),
                new Planet(8450000, 121230000, "JFHD34"),
            };

            testinger
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => WriteLine("received data"+ JsonConvert.SerializeObject(x)));

            
            var t = new Thread(() =>
            {   
                    IEnumerable<StellarBody> tester = Bodies;
                    foreach (var x in tester)
                    {
                    Thread.Sleep(1100);
                        testinger.OnNext(x);
                        Console.WriteLine("Data sent:" + JsonConvert.SerializeObject(x));
                    }
            });

            t.Start();

        }
    }
}
