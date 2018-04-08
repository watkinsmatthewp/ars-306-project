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
            yield return new Note { Interval = Interval.P5, Beats = .67 };
            yield return new Note { Interval = Interval.P5, Beats = .33 };

            yield return new Note { Interval = Interval.M6, Beats = 1 };
            yield return new Note { Interval = Interval.P5, Beats = 1 };
            yield return new Note { Interval = Interval.P8, Beats = 1 };

            yield return new Note { Interval = Interval.M7, Beats = 1 };
            yield return new Note { Beats = 1 };
            yield return new Note { Interval = Interval.P5, Beats = .67 };
            yield return new Note { Interval = Interval.P5, Beats = .33 };

            yield return new Note { Interval = Interval.M6, Beats = 1 };
            yield return new Note { Interval = Interval.P5, Beats = 1 };
            yield return new Note { OctaveOffset = 1, Interval = Interval.M2, Beats = 1 };

            yield return new Note { Interval = Interval.P8, Beats = 1 };
        }
    }
}
