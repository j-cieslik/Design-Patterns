using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fasada
{
    public class QualityScanner
    {
        public IEnumerable<string> QualityScan(string githbUrl)
        {
            Console.WriteLine("Quality scan");

            return new List<string>() { "Error1", "Error2" };
        }
    }
}