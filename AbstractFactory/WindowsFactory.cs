using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class WindowsFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextbox CreateTextbox()
        {
            return new WindowsTextbox();
        }
    }
}