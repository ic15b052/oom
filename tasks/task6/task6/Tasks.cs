using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace task6
{
    class Tasks
    {
        public static void gogo()
        {

            var result = Task.Run(() =>
             {
                 Task.Delay(TimeSpan.FromMilliseconds(2000)).Wait();
                 return 1;
             });

            result.ContinueWith(t => WriteLine(t.Result));

            var tries = GuessNumber();

            


            WriteLine("Tries:" + tries.Result);

        }

        public static async Task<int> GuessNumber()
        { 
            int tries = 0;
            
            var random2 = new Random();
            var x = random2.Next(50);

            WriteLine("to find:" + x);


            while (tries <= 40)
            {
                if (await isHit(x, random2.Next(50)))
                    return tries;
                tries++;
            }

            return -1;

        }

        public static Task<bool>isHit(int x,int tried)
        {
            return Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromMilliseconds(250)).Wait();
                //WriteLine("Trying:" + tried);

                if (x == tried)
                    return true;
                return false;
            });

        }
    }
}
