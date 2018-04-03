using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dumbposer
{
    public class ConsolePlayer : IPlayer
    {
        int _msPerBeat;

        public bool MakeSound { get; set; }
        public bool Debug { get; set; }

        public int BeatsPerSecond
        {
            get => 60000 / _msPerBeat;
            set => _msPerBeat = 60000 / value;
        }

        public void Play(Note note)
        {
            var durationMs = (int)(note.Beats * _msPerBeat);
            if (note.Tone == null)
            {
                if (Debug)
                {
                    Console.WriteLine($"Resting for {durationMs} ms");
                }
                if (MakeSound)
                {
                    Thread.Sleep(durationMs);
                }
            }
            else
            {
                if (Debug)
                {
                    Console.WriteLine($"Playing {note.Tone.FullName} ({note.Tone.Frequency} Hz) for {durationMs} ms");
                }
                if (MakeSound)
                {
                    Console.Beep((int)note.Tone.Frequency, durationMs);
                }
            }
        }
    }
}
