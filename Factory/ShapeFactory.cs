using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Triangle:
                    return new Traingle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                default:
                    throw new Exception($"Shape type {type} is not handled");
            }
        }
    }
}