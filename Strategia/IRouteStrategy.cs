using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Strategia
{
    public interface IRouteStrategy
    {
        void CreateRoute(Coordinate start, Coordinate end);
    }
}