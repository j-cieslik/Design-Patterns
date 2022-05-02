using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class WindowsTextbox : ITextbox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle windows text input");
        }

        public void Render()
        {
            Console.WriteLine("Render windows textbox");
        }
    }
}