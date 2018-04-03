using System;

namespace Dumbposer
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new ConsolePlayer
            {
                Debug = true,
                MakeSound = true,
                BeatsPerSecond = 120
            };

            PlayHappyBirthday(player);

            player.Play(new Note { Beats = 8 });

            PlayRandomNotes(player);
        }

        static void PlayHappyBirthday(ConsolePlayer player)
        {
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
        }

        static void PlayRandomNotes(ConsolePlayer player)
        {
            var random = new Random();
            for (var i = 0; i < 1000; i++)
            {
                var toneName = (char)random.Next('A', 'G' + 1);
                var octaveNumber = random.Next(2, 8);
                var beats = random.Next(1, 17) * .0625d;
                player.Play(new Note
                {
                    Beats = beats,
                    Tone = new Tone
                    {
                        FullName = $"{toneName}{octaveNumber}"
                    }
                });
            }
        }
    }
}
