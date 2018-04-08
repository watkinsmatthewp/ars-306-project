using Dumbposer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dumbposer.Printers
{
    public interface IMelodyPrinter
    {
        void Print(Stream stream, Melody melody);
    }
}
