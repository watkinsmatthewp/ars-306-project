using Dumbposer.Entities;
using System;
using System.Threading;

namespace Dumbposer.Players
{
    public class ConsolePlayer : IPlayer
    {
        public bool MakeSound { get; set; } = true;
        public bool Debug { get; set; } = true;

        public void Play(MelodyContext context, Melody melody)
        {
            var msPerBeat = 60000d / context.BeatsPerMinute;
            foreach (var note in melody.GetNotes())
            {
                var durationMs = (int)(note.Beats * msPerBeat);
                if (note.IsRest)
                {
                    if (Debug)
                    {
                        Console.WriteLine($"Resting for {note.Beats} beats ({durationMs} ms)");
                    }
                    if (MakeSound)
                    {
                        Thread.Sleep(durationMs);
                    }
                }
                else
                {
                    var tone = note.GetTone(context.HomeTonic);
                    if (Debug)
                    {
                        Console.WriteLine($"Playing {tone.FullName} ({tone.Frequency} Hz) for {note.Beats} beats ({durationMs} ms)");
                    }
                    if (MakeSound)
                    {
                        Console.Beep((int)tone.Frequency, durationMs);
                    }
                }
            }
        }
    }
}
