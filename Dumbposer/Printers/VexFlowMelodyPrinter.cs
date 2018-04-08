using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Dumbposer.Entities;

namespace Dumbposer.Printers
{
    public class VexFlowMelodyPrinter : IMelodyPrinter
    {
        static readonly Dictionary<double, string> DURATION_NOTATION = new Dictionary<double, string >
        {
            [.25] = "16",
            [.33] = "8",
            [.5] = "8",
            [.67] = "q",
            [.75] = "8d",
            [1] = "q",
            [2] = "h",
            [3] = "hd",
            [4] = "w"
        };

        public void Print(Stream stream, Melody melody)
        {
            var cTone = new Tone { ID = 40 };
            var streamWriter = new StreamWriter(stream);
            for (var m = 0; m < melody.Measures.Count; m++)
            {
                if (m % 4 == 0)
                {
                    streamWriter.Write($"tabstave notation=true tablature=false");
                    if (m == 0)
                    {
                        streamWriter.Write($" time={melody.Measures[1].TotalBeatCapacity}/4");
                    }
                    streamWriter.WriteLine();
                    streamWriter.Write("notes ");
                }
                var measure = melody.Measures[m];
                for (var i = 0; i < measure.Notes.Count; i++)
                {
                    var note = measure.Notes[i];
                    if (note.IsRest)
                    {
                        streamWriter.Write(" ##");
                    }
                    else
                    {
                        var tone = note.GetTone(cTone);
                        streamWriter.Write($" :{DURATION_NOTATION[note.Beats]} {tone.Name}/{tone.Octave}");
                    }
                }
                streamWriter.Write(" |");
                if (m % 4 == 3)
                {
                    streamWriter.WriteLine();
                }
            }
            streamWriter.WriteLine();
            streamWriter.Flush();
        }
    }
}
