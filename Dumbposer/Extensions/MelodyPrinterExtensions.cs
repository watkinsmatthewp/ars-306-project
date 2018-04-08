using Dumbposer.Entities;
using Dumbposer.Printers;
using System.IO;
using System.Text;

namespace Dumbposer.Extensions
{
    public static class MelodyPrinterExtensions
    {
        public static string Print(this IMelodyPrinter printer, Melody melody)
        {
            using (var ms = new MemoryStream())
            {
                printer.Print(ms, melody);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
    }
}
