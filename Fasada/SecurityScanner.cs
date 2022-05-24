using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fasada
{
    public class SecurityScanner
    {
        public IEnumerable<string> SecurityScan(string githubUrl)
        {
            Console.WriteLine("Security scan");

            return new List<string>() { "security error1" };
        }
    }
}