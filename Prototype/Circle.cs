using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }

        public override Shape Clone()
        {
            Circle cloneBase = (Circle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };

            return cloneBase;
        }
    }
}