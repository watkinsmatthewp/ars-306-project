using System;
using System.Threading;

namespace Dumbposer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var player = new ConsolePlayer
            {
                Debug = true,
                MakeSound = true,
                BeatsPerSecond = 120
            };

            player.Play(new Note { Tone = new Tone { FullName = "G4" }, Beats = .67 });
            player.Play(new Note { Tone = new Tone { FullName = "G4" }, Beats = .33 });
            player.Play(new Note { Tone = new Tone { FullName = "A4" }, Beats = 1 });
            player.Play(new Note { Tone = new Tone { FullName = "G4" }, Beats = 1 });
            player.Play(new Note { Tone = new Tone { FullName = "C5" }, Beats = 1 });
            player.Play(new Note { Tone = new Tone { FullName = "B4" }, Beats = 1.5 });
            player.Play(new Note { Beats = .5 });

            player.Play(new Note { Tone = new Tone { FullName = "G4" }, Beats = .67 });
            player.Play(new Note { Tone = new Tone { FullName = "G4" }, Beats = .33 });
            player.Play(new Note { Tone = new Tone { FullName = "A4" }, Beats = 1 });
            player.Play(new Note { Tone = new Tone { FullName = "G4" }, Beats = 1 });
            player.Play(new Note { Tone = new Tone { FullName = "D5" }, Beats = 1 });
            player.Play(new Note { Tone = new Tone { FullName = "C5" }, Beats = 1.5 });
            player.Play(new Note { Beats = .5 });

            Console.ReadKey();
        }
    }
}
