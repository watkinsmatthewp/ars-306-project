using System;
using System.Collections.Generic;
using System.Text;

namespace Dumbposer.Entities
{
    public class MelodyContext
    {
        public Tone HomeTonic { get; set; } = new Tone { FullName = "C4" };
        public int BeatsPerMinute { get; set; } = 90;
    }
}
