using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class MacTextbox : ITextbox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle Mac text input");
        }

        public void Render()
        {
            Console.WriteLine("Render Mac textbox");
        }
    }
}