using System;
using Dumbposer.Entities;
using Dumbposer.Extensions;

namespace Dumbposer.Composition
{
    public class RandomCompositionStrategyInput
    {
        public int NumberOfMeasures { get; set; } = 4;
        public int ChanceOfRestOneIn { get; set; } = 8;
        public int MinOctaveOffset { get; set; } = -1;
        public int MaxOctaveOffset { get; set; } = 1;
        public double MinNoteBeats { get; set; } = .33d;
        public double MaxNoteBeats { get; set; } = 2;
        public int[] AllowedIntervals { get; set; }

        private int? _beatsPerMeasure;
        public int BeatsPerMeasure
        {
            get => _beatsPerMeasure ?? (_beatsPerMeasure = Random.Next(3, 7)).Value;
            set => _beatsPerMeasure = value;
        }

        public Random Random { get; set; } = new Random();
    }

    public class RandomCompositionStrategy : ICompositionStrategy<RandomCompositionStrategyInput>
    {
        public Melody Compose(RandomCompositionStrategyInput input)
        {
            var melody = new Melody();
            for (var i = 0; i < input.NumberOfMeasures; i++)
            {
                var measure = new Measure { TotalBeatCapacity = input.BeatsPerMeasure };
                while (!measure.Full)
                {
                    var note = new Note();
                    if (!input.Random.ChanceOfOneIn(input.ChanceOfRestOneIn))
                    {
                        if (input.AllowedIntervals?.Length > 0)
                        {
                            note.Interval = input.AllowedIntervals[input.Random.Next(0, input.AllowedIntervals.Length)];
                        }
                        else
                        {
                            note.Interval = input.Random.Next(12);
                        }
                        
                        note.OctaveOffset = input.Random.Next(input.MinOctaveOffset, input.MaxOctaveOffset + 1);
                    }
                    note.Beats = Math.Min(measure.AvailableBeats, input.MinNoteBeats * input.Random.Next(1, (int)(input.MaxNoteBeats / input.MinNoteBeats) + 1));
                    measure.Notes.Add(note);
                }
                melody.Measures.Add(measure);
            }
            return melody;
        }
    }
}
