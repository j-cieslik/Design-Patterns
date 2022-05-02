using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Render windows button");
        }

        public void Render()
        {
            Console.WriteLine("Handle windows click event");
        }
    }
}