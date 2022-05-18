using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Strategia
{
    public class CarStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Car strategy");
        }
    }
}