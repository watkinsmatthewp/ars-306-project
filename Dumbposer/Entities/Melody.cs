using System;
using System.Collections.Generic;

namespace Dumbposer.Entities
{
    public class Melody
    {
        public List<Measure> Measures = new List<Measure>();

        public static Melody FromNotes(int beatsPerMeasure, int leadingBeats, IEnumerable<Note> notes)
        {
            var melody = new Melody();
            var measure = new Measure { TotalBeatCapacity = leadingBeats > 0 ? leadingBeats : beatsPerMeasure };

            foreach (var note in notes)
            {
                measure.Notes.Add(note);
                if (measure.Full)
                {
                    melody.Measures.Add(measure);
                    measure = new Measure { TotalBeatCapacity = beatsPerMeasure };
                }
            }

            if (!measure.Full)
            {
                measure.TotalBeatCapacity = (int)Math.Ceiling(measure.ReservedBeats);
                if (!measure.Full)
                {
                    measure.Notes.Add(new Note { Beats = measure.AvailableBeats });
                }
                melody.Measures.Add(measure);
            }

            return melody;
        }

        public IEnumerable<Note> GetNotes()
        {
            foreach (var measure in Measures)
            {
                foreach (var note in measure.Notes)
                {
                    yield return note;
                }
            }
        }
    }
}
