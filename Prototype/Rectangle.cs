using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Rectangle");
        }

        public override Shape Clone()
        {
            Rectangle cloneBase = (Rectangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };

            return cloneBase;
        }
    }
}