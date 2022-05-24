using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fasada
{
    public class ScanFascade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner(); 
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();

        public void Scan(string githubUrl)
        {
            Console.WriteLine($"Scanning...");

            var qualityScanErrors = qualityScanner.QualityScan(githubUrl);
            var securityScanErrors = securityScanner.SecurityScan(githubUrl);
            var dependencyScanErrors = dependencyScanner.DependencyScan(githubUrl);

            Console.WriteLine("Scan report");
            reportGenerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
        }

    }
}