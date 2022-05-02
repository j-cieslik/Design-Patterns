using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface ITextbox
    {
        void Render();
        void HandleInput();
    }
}