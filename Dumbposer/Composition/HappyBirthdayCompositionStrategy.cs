using System;
using System.Collections.Generic;
using System.Text;
using Dumbposer.Entities;

namespace Dumbposer.Composition
{
    public class HappyBirthdayCompositionStrategy : ICompositionStrategy<object>
    {
        public Melody Compose(object input) => Melody.FromNotes(3, 1, GetNotes());

        private IEnumerable<Note> GetNotes()
        {
            yield return new Note { Interval = Intervals.P5, Beats = .67 };
            yield return new Note { Interval = Intervals.P5, Beats = .33 };

            yield return new Note { Interval = Intervals.M6, Beats = 1 };
            yield return new Note { Interval = Intervals.P5, Beats = 1 };
            yield return new Note { Interval = Intervals.P8, Beats = 1 };

            yield return new Note { Interval = Intervals.M7, Beats = 1 };
            yield return new Note { Beats = 1 };
            yield return new Note { Interval = Intervals.P5, Beats = .67 };
            yield return new Note { Interval = Intervals.P5, Beats = .33 };

            yield return new Note { Interval = Intervals.M6, Beats = 1 };
            yield return new Note { Interval = Intervals.P5, Beats = 1 };
            yield return new Note { OctaveOffset = 1, Interval = Intervals.M2, Beats = 1 };

            yield return new Note { Interval = Intervals.P8, Beats = 1 };
        }
    }
}
