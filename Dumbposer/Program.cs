using Dumbposer.Composition;
using Dumbposer.Entities;
using Dumbposer.Extensions;
using Dumbposer.Players;
using Dumbposer.Printers;
using System;

namespace Dumbposer
{
    class Program
    {
        static void Main(string[] args)
        {
            var melody = new RandomCompositionStrategy().Compose(new RandomCompositionStrategyInput
            {
                // Random = new Random(1234567890),
                BeatsPerMeasure = 3,
                ChanceOfRestOneIn = 9,
                MaxNoteBeats = 1,
                MinNoteBeats = 1,
                MinOctaveOffset = 0,
                MaxOctaveOffset = 0,
                NumberOfMeasures = 24,
                AllowedIntervals = Scale.Major
            });

            Console.WriteLine(new VexFlowMelodyPrinter().Print(melody));

            var player = new ConsolePlayer
            {
                Debug = true,
                MakeSound = true,
            };

            var melodyContext = new MelodyContext
            {
                BeatsPerMinute = 180
            };

            player.Play(melodyContext, melody);

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
