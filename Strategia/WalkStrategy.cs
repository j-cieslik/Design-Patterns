using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Strategia
{
    public class WalkStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Walk strategy");
        }
    }
}