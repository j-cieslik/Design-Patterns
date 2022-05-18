using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }

        public override Shape Clone()
        {
            Triangle cloneBase = (Triangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };

            return cloneBase;
        }
    }
}