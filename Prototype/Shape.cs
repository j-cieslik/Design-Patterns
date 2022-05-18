using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Prototype
{
    public abstract class Shape 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Border Border { get; set; }

        public abstract void Render();
        public abstract Shape Clone();
    }
}