using System;
using System.Collections.Generic;
using System.Linq;

namespace HFC_Birds_Away
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> myFlock = new List<Duck>()
            {
                new Duck(){Size=12, Kind= Duck.KindOfDuck.Loon},
                new Duck(){Size=15, Kind = Duck.KindOfDuck.Peking},
                new Duck(){Size=19, Kind = Duck.KindOfDuck.Muscovy},
                new Duck(){Size = 10, Kind = Duck.KindOfDuck.Mallard},
                new Duck(){Size = 14, Kind = Duck.KindOfDuck.Muscovy},
                new Duck(){Size = 15, Kind = Duck.KindOfDuck.Loon}
            };

           IEnumerable<Bird> upcastFlock = myFlock;
            Bird.FlyAway(upcastFlock.ToList(), "Minnesota");
        }
    }
}
