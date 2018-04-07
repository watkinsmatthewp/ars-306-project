using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dumbposer.Entities
{
    public class Measure
    {
        public int TotalBeatCapacity { get; set; }
        public double ReservedBeats => Notes.Sum(n => n.Beats);
        public double AvailableBeats => TotalBeatCapacity - ReservedBeats;
        public bool Full => AvailableBeats <= 0;
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
