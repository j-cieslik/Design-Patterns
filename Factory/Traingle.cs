using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Factory
{
    public class Traingle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}