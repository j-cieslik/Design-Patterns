using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fasada
{
    public class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string githubUrl)
        {
            Console.WriteLine("Dependency Scan");

            return new List<string>() { "DependencyScan Error1" };
        }



    }
}