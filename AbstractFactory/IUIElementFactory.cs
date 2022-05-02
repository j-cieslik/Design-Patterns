using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface IUIElementFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}